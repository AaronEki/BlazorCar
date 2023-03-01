using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCar.Server.Migrations
{
    /// <inheritdoc />
    public partial class CarVariants2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarVariant",
                keyColumns: new[] { "CarId", "EditionId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 25250m, 25000m });

            migrationBuilder.UpdateData(
                table: "CarVariant",
                keyColumns: new[] { "CarId", "EditionId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 47500m, 47000m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarVariant",
                keyColumns: new[] { "CarId", "EditionId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 5250m, 5000m });

            migrationBuilder.UpdateData(
                table: "CarVariant",
                keyColumns: new[] { "CarId", "EditionId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "OriginalPrice", "Price" },
                values: new object[] { 7500m, 7000m });
        }
    }
}
