using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCar.Server.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8262));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 8, 4, 896, DateTimeKind.Local).AddTicks(941));
        }
    }
}
