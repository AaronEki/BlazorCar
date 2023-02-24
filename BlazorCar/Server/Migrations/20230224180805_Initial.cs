using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorCar.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mileage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Engine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gearbox = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bodystyle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Doors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Hatchback", "hatchback" },
                    { 2, "Estate", "estate" },
                    { 3, "SUV", "suv" },
                    { 4, "Coupe", "coupe" },
                    { 5, "Specials", "specials" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Bodystyle", "CategoryId", "Colour", "DateCreated", "DateUpdated", "Description", "Doors", "Engine", "Gearbox", "Image", "IsDeleted", "IsPublic", "Mileage", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Hatchback", 1, "Rebel Blue", new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(895), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volvo V40 1996cc 5dr", "5", "2.0L Diesel", "Automatic", "/images/v40.jpg", false, false, "47,500", 13000m, 12579m, "Volvo V40 Hatchback 2015" },
                    { 2, "Hatchback", 5, "Panda", new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(924), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iconic Panda Tureno AE86 - 1570cc 3dr - Perfect for Delivering Tofu Across Akina!", "3", "1.6L Petrol", "Manual", "/images/toyota-ae86.jpg", false, false, "92820", 29000m, 26000m, "Toyota AE86 - 1987" },
                    { 3, "Hatchback", 1, "Blaze Red", new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(927), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vauxhall Corsa 1160cc 3dr", "3", "1.2L Petrol", "Manual", "/images/corsa.jpg", false, false, "48,500", 5330m, 5325m, "Vauxhall Corsa Hatchback 2015" },
                    { 4, "Estate", 2, "Corrida Red", new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(929), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skoda Octavia 1570cc 5dr", "5", "1.6L Diesel", "Automatic", "/images/skoda-octavia-estate.jpg", false, false, "48,500", 10650m, 10650m, "Skoda Octavia Estate 2017" },
                    { 5, "Estate", 2, "Black", new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(931), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skoda Octavia 2993cc 5dr", "5", "3.0L Diesel", "Automatic", "/images/bmw-520d.jpg", false, false, "11,200", 44000m, 43500m, "BMW 520d Estate 2023" },
                    { 6, "Hatchback", 1, "Black", new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(933), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honda Civic Type R 182hp Hot Hatchback 1570cc 3dr", "3", "1.6L Petrol", "Manual", "/images/civic-1997.jpg", false, false, "170000", 8000m, 7000m, "Honda Civic Type R 1997" },
                    { 7, "SUV", 3, "Grey", new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(935), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1.5L T5 Pro Volvo XC40 1570cc 3dr", "5", "1.5L Petrol", "Manual", "/images/xc40.jpg", false, false, "170000", 41990m, 41990m, "Volvo XC40 2021" },
                    { 8, "Coupe", 5, "Grey", new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(937), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nissan R34 2.6L Twin-Turbocharged RB26 2606cc 3dr", "3", "2.6L Petrol", "Manual", "/images/r34-skyline.jpg", false, false, "9000", 39460m, 39460m, "Nissan Skyline GTR R34 2001" },
                    { 9, "Coupe", 4, "Grey", new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(939), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porsche Cayman 718 GT4 RS Coupe 3997cc 3dr", "3", "4.0L Petrol", "Automatic", "/images/porsche.jpg", false, false, "2500", 123400m, 123400m, "Porsche 718 Cayman GT4 RS 2022" },
                    { 10, "Coupe", 4, "Red", new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(941), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honda NSX 3.0L VTEC 2997cc 3dr", "3", "3.0L Petrol", "Manual", "/images/nsx.jpg", false, false, "2500", 86000m, 84000m, "Honda NSX 1990" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
