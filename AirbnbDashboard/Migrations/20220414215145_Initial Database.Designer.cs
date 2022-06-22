﻿// <auto-generated />
using System;
using AirbnbDashboard.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirbnbDashboard.Migrations
{
    [DbContext(typeof(AirbnbDashboardContext))]
    [Migration("20220414215145_Initial Database")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AirbnbDashboard.Model.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Email = "JPJansen@gmail.com",
                            FirstName = "Jan-Pieter",
                            Lastname = "Jansen"
                        },
                        new
                        {
                            id = 2,
                            Email = "NienkeVries@hotmail.com",
                            FirstName = "Nienke",
                            Lastname = "Vries"
                        });
                });

            modelBuilder.Entity("AirbnbDashboard.Model.House", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("MaxPeople")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfBeds")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<bool>("Pets")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<bool>("Smoking")
                        .HasColumnType("bit");

                    b.Property<int>("TypeHouse")
                        .HasColumnType("int");

                    b.Property<bool>("Wifi")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("LandlordId");

                    b.ToTable("Houses");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Description = "Mooi aan zee",
                            HouseAdress = "Almereweg 1",
                            HouseCity = "Almere",
                            LandlordId = 2,
                            MaxPeople = 4,
                            NumberOfBeds = 4,
                            NumberOfRooms = 3,
                            Pets = true,
                            Price = 35.5,
                            Smoking = false,
                            TypeHouse = 1,
                            Wifi = true
                        },
                        new
                        {
                            id = 2,
                            Description = "Zeer mooi",
                            HouseAdress = "Flevolandlaan 1",
                            HouseCity = "Lelystad",
                            LandlordId = 1,
                            MaxPeople = 7,
                            NumberOfBeds = 6,
                            NumberOfRooms = 4,
                            Pets = true,
                            Price = 49.990000000000002,
                            Smoking = true,
                            TypeHouse = 2,
                            Wifi = true
                        });
                });

            modelBuilder.Entity("AirbnbDashboard.Model.Landlord", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("landlords");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Email = "JohnBakker@gmail.com",
                            FirstName = "John",
                            LastName = "Baker",
                            Phone = "061234567890"
                        },
                        new
                        {
                            id = 2,
                            Email = "StevenGooje@gmail.com",
                            FirstName = "Steven",
                            LastName = "Gooje",
                            Phone = "060987654321"
                        });
                });

            modelBuilder.Entity("AirbnbDashboard.Model.Reservation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HouseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("HouseId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CustomerId = 1,
                            EndDate = new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HouseId = 1,
                            StartDate = new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            id = 2,
                            CustomerId = 2,
                            EndDate = new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HouseId = 2,
                            StartDate = new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("AirbnbDashboard.Model.House", b =>
                {
                    b.HasOne("AirbnbDashboard.Model.Landlord", "Landlord")
                        .WithMany("Houses")
                        .HasForeignKey("LandlordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landlord");
                });

            modelBuilder.Entity("AirbnbDashboard.Model.Reservation", b =>
                {
                    b.HasOne("AirbnbDashboard.Model.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirbnbDashboard.Model.House", "House")
                        .WithMany("Reservations")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("House");
                });

            modelBuilder.Entity("AirbnbDashboard.Model.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("AirbnbDashboard.Model.House", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("AirbnbDashboard.Model.Landlord", b =>
                {
                    b.Navigation("Houses");
                });
#pragma warning restore 612, 618
        }
    }
}
