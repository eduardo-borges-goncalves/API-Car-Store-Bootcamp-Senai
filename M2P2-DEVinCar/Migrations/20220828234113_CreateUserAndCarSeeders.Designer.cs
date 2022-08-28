﻿// <auto-generated />
using System;
using M2P2_DEVinCar.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace M2P2_DEVinCar.Migrations
{
    [DbContext(typeof(DEVInCarContext))]
    [Migration("20220828234113_CreateUserAndCarSeeders")]
    partial class CreateUserAndCarSeeders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("M2P2_DEVinCar.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Complement")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("M2P2_DEVinCar.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("SuggestedPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Punto",
                            SuggestedPrice = 38000.00m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Prisma",
                            SuggestedPrice = 42000.00m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fusca",
                            SuggestedPrice = 10000.00m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kombi",
                            SuggestedPrice = 8000.00m
                        },
                        new
                        {
                            Id = 5,
                            Name = "TR-4",
                            SuggestedPrice = 180000.00m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Camaro",
                            SuggestedPrice = 308000.00m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Toro",
                            SuggestedPrice = 138000.00m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Pulse",
                            SuggestedPrice = 88000.00m
                        },
                        new
                        {
                            Id = 9,
                            Name = "Nivus",
                            SuggestedPrice = 78000.00m
                        },
                        new
                        {
                            Id = 10,
                            Name = "Hilux",
                            SuggestedPrice = 238000.00m
                        });
                });

            modelBuilder.Entity("M2P2_DEVinCar.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("M2P2_DEVinCar.Models.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeliveryForecast")
                        .HasColumnType("datetime2");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("SaleId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("M2P2_DEVinCar.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BuyerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SellerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("SellerId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("M2P2_DEVinCar.Models.SaleCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleCars");
                });

            modelBuilder.Entity("M2P2_DEVinCar.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Initials")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Initials = "AC",
                            Name = "Acre"
                        },
                        new
                        {
                            Id = 2,
                            Initials = "AL",
                            Name = "Alagoas"
                        },
                        new
                        {
                            Id = 3,
                            Initials = "AP",
                            Name = "Amapá"
                        },
                        new
                        {
                            Id = 4,
                            Initials = "AM",
                            Name = "Amazonas"
                        },
                        new
                        {
                            Id = 5,
                            Initials = "BA",
                            Name = "Bahia"
                        },
                        new
                        {
                            Id = 6,
                            Initials = "CE",
                            Name = "Ceará"
                        },
                        new
                        {
                            Id = 7,
                            Initials = "DF",
                            Name = "Distrito Federal"
                        },
                        new
                        {
                            Id = 8,
                            Initials = "ES",
                            Name = "Espírito Santo"
                        },
                        new
                        {
                            Id = 9,
                            Initials = "GO",
                            Name = "Goiás"
                        },
                        new
                        {
                            Id = 10,
                            Initials = "MA",
                            Name = "Maranhão"
                        },
                        new
                        {
                            Id = 11,
                            Initials = "MT",
                            Name = "Mato Grosso"
                        },
                        new
                        {
                            Id = 12,
                            Initials = "MS",
                            Name = "Mato Grosso do Sul"
                        },
                        new
                        {
                            Id = 13,
                            Initials = "MG",
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            Id = 14,
                            Initials = "PA",
                            Name = "Pará"
                        },
                        new
                        {
                            Id = 15,
                            Initials = "PB",
                            Name = "Paraíba"
                        },
                        new
                        {
                            Id = 16,
                            Initials = "PR",
                            Name = "Paraná"
                        },
                        new
                        {
                            Id = 17,
                            Initials = "PE",
                            Name = "Pernambuco"
                        },
                        new
                        {
                            Id = 18,
                            Initials = "PI",
                            Name = "Piauí"
                        },
                        new
                        {
                            Id = 19,
                            Initials = "RJ",
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 20,
                            Initials = "RN",
                            Name = "Rio Grande do Norte"
                        },
                        new
                        {
                            Id = 21,
                            Initials = "RS",
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = 22,
                            Initials = "RO",
                            Name = "Rondônia"
                        },
                        new
                        {
                            Id = 23,
                            Initials = "RR",
                            Name = "Roraima"
                        },
                        new
                        {
                            Id = 24,
                            Initials = "SC",
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            Id = 25,
                            Initials = "SP",
                            Name = "São Paulo"
                        },
                        new
                        {
                            Id = 26,
                            Initials = "SE",
                            Name = "Sergipe"
                        },
                        new
                        {
                            Id = 27,
                            Initials = "TO",
                            Name = "Tocantins"
                        });
                });

            modelBuilder.Entity("M2P2_DEVinCar.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "matheus.gevartosky@senai.com",
                            Name = "Matheus Gevartosky",
                            Password = "123456789"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rodrigo.raiche@senai.com",
                            Name = "Rodrigo Raiche",
                            Password = "123456789"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lucas.reibnitz@senai.com",
                            Name = "Lucas Reibnitz",
                            Password = "123456789"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alessandra.soares@senai.com",
                            Name = "Alessandra Soares",
                            Password = "123456789"
                        });
                });

            modelBuilder.Entity("M2P2_DEVinCar.Models.Address", b =>
                {
                    b.HasOne("M2P2_DEVinCar.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("M2P2_DEVinCar.Models.City", b =>
                {
                    b.HasOne("M2P2_DEVinCar.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("M2P2_DEVinCar.Models.Delivery", b =>
                {
                    b.HasOne("M2P2_DEVinCar.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("M2P2_DEVinCar.Models.Sale", "Sale")
                        .WithMany()
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("M2P2_DEVinCar.Models.Sale", b =>
                {
                    b.HasOne("M2P2_DEVinCar.Models.User", "Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("M2P2_DEVinCar.Models.User", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("M2P2_DEVinCar.Models.SaleCar", b =>
                {
                    b.HasOne("M2P2_DEVinCar.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("M2P2_DEVinCar.Models.Sale", "Sale")
                        .WithMany()
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Sale");
                });
#pragma warning restore 612, 618
        }
    }
}
