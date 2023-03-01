using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorCar.Server.Migrations
{
    /// <inheritdoc />
    public partial class CarVariants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarEdition");

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "EditionId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CarVariant",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false),
                    EditionId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarVariant", x => new { x.CarId, x.EditionId });
                    table.ForeignKey(
                        name: "FK_CarVariant_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarVariant_Editions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarVariant",
                columns: new[] { "CarId", "EditionId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 1, 12750m, 12599m },
                    { 1, 2, 12999m, 12749m },
                    { 1, 3, 13149m, 12899m },
                    { 1, 4, 13299m, 13049m },
                    { 2, 1, 5250m, 5000m },
                    { 3, 1, 5400m, 5150m },
                    { 3, 2, 5550m, 5300m },
                    { 3, 3, 5700m, 5450m },
                    { 3, 4, 5850m, 5600m },
                    { 4, 1, 9000m, 9000m },
                    { 4, 2, 9150m, 9150m },
                    { 4, 3, 9300m, 9300m },
                    { 4, 4, 9450m, 9450m },
                    { 5, 1, 43500m, 43500m },
                    { 5, 2, 43650m, 43650m },
                    { 5, 3, 43800m, 43800m },
                    { 5, 4, 43950m, 43950m },
                    { 6, 1, 7500m, 7000m },
                    { 7, 1, 7500m, 7000m },
                    { 8, 1, 39600m, 39500m },
                    { 9, 1, 125000m, 125000m },
                    { 9, 2, 126000m, 126000m },
                    { 9, 3, 127000m, 127000m },
                    { 10, 1, 87000m, 87000m },
                    { 10, 4, 90000m, 90000m }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "EditionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "EditionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "EditionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "EditionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "EditionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "EditionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "EditionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "EditionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "EditionId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "EditionId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_EditionId",
                table: "Cars",
                column: "EditionId");

            migrationBuilder.CreateIndex(
                name: "IX_CarVariant_EditionId",
                table: "CarVariant",
                column: "EditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Editions_EditionId",
                table: "Cars",
                column: "EditionId",
                principalTable: "Editions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Editions_EditionId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "CarVariant");

            migrationBuilder.DropIndex(
                name: "IX_Cars_EditionId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EditionId",
                table: "Cars");

            migrationBuilder.AddColumn<decimal>(
                name: "OriginalPrice",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "CarEdition",
                columns: table => new
                {
                    CarsId = table.Column<int>(type: "int", nullable: false),
                    EditionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarEdition", x => new { x.CarsId, x.EditionsId });
                    table.ForeignKey(
                        name: "FK_CarEdition_Cars_CarsId",
                        column: x => x.CarsId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarEdition_Editions_EditionsId",
                        column: x => x.EditionsId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarEdition",
                columns: new[] { "CarsId", "EditionsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 1 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 6, 4 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 7, 4 },
                    { 8, 1 },
                    { 9, 1 },
                    { 9, 2 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 10, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 13000m, 12579m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 29000m, 26000m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 5330m, 5325m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 10650m, 10650m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 44000m, 43500m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 8000m, 7000m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 41990m, 41990m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 39460m, 39460m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 123400m, 123400m });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 86000m, 84000m });

            migrationBuilder.CreateIndex(
                name: "IX_CarEdition_EditionsId",
                table: "CarEdition",
                column: "EditionsId");
        }
    }
}
