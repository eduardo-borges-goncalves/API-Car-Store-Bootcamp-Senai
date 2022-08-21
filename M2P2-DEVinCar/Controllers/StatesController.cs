﻿using M2P2_DEVinCar.Context;
using M2P2_DEVinCar.Dtos;
using M2P2_DEVinCar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace M2P2_DEVinCar.Controllers
{
    [Route("api/state")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private DEVInCarContext _context;
        private readonly ILogger<StatesController> _logger;

        public StatesController(DEVInCarContext context, ILogger<StatesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Adiciona uma Cidade no banco de dados.
        /// </summary>
        /// <param name="stateId">ID do estado</param>
        /// <param name="CreateCityDto">DTO de cidade contendo apenas o nome</param>
        /// <returns>Retorna Cidade inserida com sucesso no banco de dados</returns>
        /// <response code="201">Cidade inserida com sucesso</response>
        /// <response code="400">Esta cidade já está registrada no banco de dados</response>
        /// <response code="404">ID de estado inválido</response>
        /// <response code="500">Ocorreu exceção durante a operação</response>
        [HttpPost("{stateId}/city")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostCity(int stateId, [FromBody] CreateCityDto cityDto)
        {
            try
            {
                bool stateIsValid = await _context.States
                    .AnyAsync(state => state.Id == stateId);

                if (stateIsValid == false)
                    return NotFound();

                bool cityAlreadyExists = await _context.Cities
                    .AnyAsync(city => city.Name == cityDto.Name
                    && city.StateId == stateId);

                if (cityAlreadyExists == true)
                    return BadRequest();

                City city = new City()
                {
                    StateId = stateId,
                    Name = cityDto.Name
                };

                _context.Cities.Add(city);
                await _context.SaveChangesAsync();

                _logger.LogInformation($"Controller:{nameof(StatesController)}-Method:{nameof(PostCity)}");

                return StatusCode(201, new { Id = city.Id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Controller:{nameof(StatesController)}-Method:{nameof(PostCity)}");
                return StatusCode(500);
            }
        }

        /*
        ● Caso não exista nenhum registro de Estado com o stateId enviado, deve ser retornado o Status de Erro 404 (Not Found)
        ● Caso exista alguma outra cidade criada nesse estado com o mesmo nome enviado,
        deve ser retornado o Status de Erro 400 (Bad Request)
        ● Caso todas as validações passem, deve ser criada uma cidade com nome e estado
        especificados, retornando o Id da cidade criada, com o Status 201 (Created)
        */



        // GET: api/<StatesController>
        /// <summary>
        /// Retorna uma lista de Estados
        /// </summary>
        /// <param name="name">Nome de algum estado</param>
        /// <returns>Retorna Estado com o nome solicitado</returns>
        /// <returns>Se não solicitado nome, retorna todos os estados.</returns>
        /// <response code="200">Retorna uma lista de estados</response>
        /// <response code="204">Não encontrou o estado</response>
        /// <response code="500">Ocorreu erro durante a execução</response>

        [HttpGet("name")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<State>>> GetState([FromQuery]string? name)
        {
            try
            {
                

                if (name != null)
                {
                    var stateName = await _context.States.FirstOrDefaultAsync(nameState => nameState.Name == name);

                    _logger.LogInformation($"Controller: {nameof(StatesController)} = Metodo: {nameof(GetState)}");
                        
                    return stateName is not null ? Ok(stateName) : StatusCode(204);
                }

                var states = await _context.States.ToListAsync();

                _logger.LogInformation($"Controller: {nameof(StatesController)} = Metodo: {nameof(GetState)}");

                return states.Any() ? Ok(states) : StatusCode(200);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Controller: {nameof(StatesController)} = Metodo: {nameof(GetState)}");
                return StatusCode(500);
            }

          
        }


        /*[HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpPost]
        public void Post([FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
