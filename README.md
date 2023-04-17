# API Car Store - English

This project is an API for a car store, developed during a bootcamp at Senai using C# as the main technology.

## Technologies Used

- C#
- ASP.NET Core 3.1
- Entity Framework Core
- Swagger

## How to run the project

1. Clone the repository
2. Open the solution in Visual Studio
3. Open the Package Manager Console and run the following command to create the database:

```bash
Update-Database
```

4. Run the project in Visual Studio
5. Open your browser and go to [https://localhost:5001/swagger/index.html](https://localhost:5001/swagger/index.html) to access the Swagger documentation

## Endpoints

The API has the following endpoints:

### GET /api/cars

Returns a list of all cars in the database.

### GET /api/cars/{id}

Returns a car by its id.

### POST /api/cars

Creates a new car.

### PUT /api/cars/{id}

Updates a car by its id.

### DELETE /api/cars/{id}

Deletes a car by its id.

## Database

The database used in this project is a Microsoft SQL Server database, created using Entity Framework Core. The database has a single table, called "Cars", which contains the following fields:

- Id (int, primary key)
- Brand (nvarchar(50), not null)
- Model (nvarchar(50), not null)
- Year (int, not null)
- Price (decimal(18,2), not null)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.


# API Car Store - Português
![cars](https://user-images.githubusercontent.com/102731743/187086692-2888d833-a6b1-4bed-9ce5-2386ef585d27.png)



Aplicação backend do DEVinCar, projeto desenvolvido pelos alunos do curso DEVinHouse Turma Audaces 2022, do SENAI/SC.

A API foi desenvolvida em .NET Core 6, em C#, conectando em base SQL Server.

## 🔨 Funcionalidades do projeto

- `Tema 1` `Módulo de Cadastro`: Responsável por manter e gerir o cadastro de usuários e produtos.
- `Tema 2` `Módulo de Vendas`: Responsável por gerir as vendas de carros e as entregas.
- `Tema 3` `Módulo de Geo-Posicionamento`: Responsável por gerir o cadastro de cidades, estados e endereços. 

![users](https://user-images.githubusercontent.com/102731743/187086800-d70e7441-e784-4d91-8f2f-9a483826544e.png)
![sales](https://user-images.githubusercontent.com/102731743/187086809-7e5b1506-ad21-4eec-8e7f-c60d2a32c6a1.png)
![addresses](https://user-images.githubusercontent.com/102731743/187086813-30cef45c-f879-4506-b9d6-c62269c0be09.png)

## ✔️ Técnicas e tecnologias utilizadas

- ``C#``
- ``ASP.NET Core 6 com Entity Framework Core 6``
- ``SQL Server``
- ``Paradigma de orientação a objetos``

## 📁 Acesso ao projeto
Você pode acessar os arquivos do projeto clicando [aqui](https://github.com/DEVin-Audaces/M2P2-DEVinCar/).

## 🚀 Pessoas desenvolvedoras do projeto
``Squad 1``
[@matheusgevartosky](https://www.github.com/matheusgevartosky)
[@ViniciusAAssuncao](https://www.github.com/ViniciusAAssuncao)
[@Queroix](https://www.github.com/Queroix)
[@brunocapistrano](https://www.github.com/brunocapistrano)
[@juliju01](https://www.github.com/juliju01)
[@eduardo-borges-goncalves](https://www.github.com/eduardo-borges-goncalves)

``Squad 2``
[@RodrigoRaiche](https://www.github.com/RodrigoRaiche)
[@Ro3son](https://www.github.com/Ro3son)
[@JoaoCoelhoSoares](https://www.github.com/JoaoCoelhoSoares)
[@BCS93](https://www.github.com/BCS93)

``Squad 3``
[@Reibnitz](https://www.github.com/Reibnitz)
[@agnaldobrito](https://www.github.com/agnaldobrito)
[@feliperi0s](https://www.github.com/feliperi0s)
[@pedrocapinos](https://www.github.com/pedrocapinos)
[@gmvilela](https://www.github.com/gmvilela)
[@Bbbias](https://www.github.com/Bbbias)
[@albertdipaula](https://www.github.com/albertdipaula)
