using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirbnbDashboard.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "landlords",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_landlords", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandlordId = table.Column<int>(type: "int", nullable: false),
                    TypeHouse = table.Column<int>(type: "int", nullable: false),
                    HouseAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: false),
                    NumberOfBeds = table.Column<int>(type: "int", nullable: false),
                    MaxPeople = table.Column<int>(type: "int", nullable: false),
                    Smoking = table.Column<bool>(type: "bit", nullable: false),
                    Pets = table.Column<bool>(type: "bit", nullable: false),
                    Wifi = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.id);
                    table.ForeignKey(
                        name: "FK_Houses_landlords_LandlordId",
                        column: x => x.LandlordId,
                        principalTable: "landlords",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    HouseId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "id", "Email", "FirstName", "Lastname" },
                values: new object[,]
                {
                    { 1, "JPJansen@gmail.com", "Jan-Pieter", "Jansen" },
                    { 2, "NienkeVries@hotmail.com", "Nienke", "Vries" }
                });

            migrationBuilder.InsertData(
                table: "landlords",
                columns: new[] { "id", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "JohnBakker@gmail.com", "John", "Baker", "061234567890" },
                    { 2, "StevenGooje@gmail.com", "Steven", "Gooje", "060987654321" }
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "id", "Description", "HouseAdress", "HouseCity", "LandlordId", "MaxPeople", "NumberOfBeds", "NumberOfRooms", "Pets", "Price", "Smoking", "TypeHouse", "Wifi" },
                values: new object[] { 2, "Zeer mooi", "Flevolandlaan 1", "Lelystad", 1, 7, 6, 4, true, 49.990000000000002, true, 2, true });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "id", "Description", "HouseAdress", "HouseCity", "LandlordId", "MaxPeople", "NumberOfBeds", "NumberOfRooms", "Pets", "Price", "Smoking", "TypeHouse", "Wifi" },
                values: new object[] { 1, "Mooi aan zee", "Almereweg 1", "Almere", 2, 4, 4, 3, true, 35.5, false, 1, true });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "id", "CustomerId", "EndDate", "HouseId", "StartDate" },
                values: new object[] { 2, 2, new DateTime(2022, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "id", "CustomerId", "EndDate", "HouseId", "StartDate" },
                values: new object[] { 1, 1, new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Houses_LandlordId",
                table: "Houses",
                column: "LandlordId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_HouseId",
                table: "Reservations",
                column: "HouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "landlords");
        }
    }
}
