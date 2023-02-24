using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCar.Server.Migrations
{
    /// <inheritdoc />
    public partial class newSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 47, 9, 549, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 47, 9, 549, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 47, 9, 549, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 47, 9, 549, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 47, 9, 549, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 47, 9, 549, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 47, 9, 549, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 47, 9, 549, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 47, 9, 549, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 47, 9, 549, DateTimeKind.Local).AddTicks(6773));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 13, 57, 626, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 13, 57, 626, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 13, 57, 626, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 13, 57, 626, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 13, 57, 626, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 13, 57, 626, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 13, 57, 626, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 13, 57, 626, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 13, 57, 626, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 2, 24, 18, 13, 57, 626, DateTimeKind.Local).AddTicks(208));
        }
    }
}
