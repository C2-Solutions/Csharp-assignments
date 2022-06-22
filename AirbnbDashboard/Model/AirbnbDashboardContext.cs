using Microsoft.EntityFrameworkCore;
using System;

namespace AirbnbDashboard.Model
{
    public class AirbnbDashboardContext : DbContext
    {
        public DbSet<House> Houses { get; set; }
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder is null)
            {
                throw new ArgumentNullException(nameof(optionsBuilder));
            }

            optionsBuilder.UseSqlServer("Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=AirbnbDashboardDb;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }

            modelBuilder.Entity<House>().HasData(
                new House
                {
                    Id = 1,
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
                    TypeHouse = TypeHouse.Bungalow,
                    Wifi = true
                },
                new House
                {
                    Id = 2,
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
                    TypeHouse = TypeHouse.Apartment,
                    Wifi = true
                }
                );

            modelBuilder.Entity<Landlord>().HasData(
                new Landlord
                {
                    Id = 1,
                    Email = "JohnBakker@gmail.com",
                    FirstName = "John",
                    LastName = "Baker",
                    Phone = "061234567890"
                },
                new Landlord
                {
                    Id = 2,
                    Email = "StevenGooje@gmail.com",
                    FirstName = "Steven",
                    LastName = "Gooje",
                    Phone = "060987654321"
                }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Email = "JPJansen@gmail.com",
                    FirstName = "Jan-Pieter",
                    Lastname = "Jansen"
                },
                new Customer
                {
                    Id = 2,
                    Email = "NienkeVries@hotmail.com",
                    FirstName = "Nienke",
                    Lastname = "Vries"
                }
                );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation
                {
                    Id = 1,
                    CustomerId = 1,
                    EndDate = new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    HouseId = 1,
                    StartDate = new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local)
                },
                new Reservation
                {
                    Id = 2,
                    CustomerId = 2,
                    EndDate = new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    HouseId = 2,
                    StartDate = new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local)
                }
            );
        }
    }
}
