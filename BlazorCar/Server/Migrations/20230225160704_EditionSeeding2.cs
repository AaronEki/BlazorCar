using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorCar.Server.Migrations
{
    /// <inheritdoc />
    public partial class EditionSeeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "No Warranty" },
                    { 2, "3 Month Warranty" },
                    { 3, "6 Month Warranty" },
                    { 4, "12 Month Warranty" }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "CarEdition",
                keyColumns: new[] { "CarsId", "EditionsId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
