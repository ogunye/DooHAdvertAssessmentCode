using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DooHAdvertAPI.Migrations
{
    /// <inheritdoc />
    public partial class ModifedSeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartTime",
                value: new DateTime(2023, 7, 4, 5, 3, 36, 757, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartTime",
                value: new DateTime(2023, 7, 4, 5, 3, 36, 757, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "Id", "CityName", "EndTime", "Path", "Priority", "StartTime" },
                values: new object[,]
                {
                    { 9, "Liverpool", new DateTime(2023, 7, 6, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/AeroTech Drones", 9, new DateTime(2023, 7, 4, 5, 3, 36, 757, DateTimeKind.Local).AddTicks(4308) },
                    { 10, "Leeds", new DateTime(2023, 7, 11, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/Solaris Solar", 10, new DateTime(2023, 7, 6, 10, 30, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartTime",
                value: new DateTime(2023, 7, 3, 18, 42, 21, 119, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 8,
                column: "StartTime",
                value: new DateTime(2023, 7, 3, 18, 42, 21, 119, DateTimeKind.Local).AddTicks(3714));
        }
    }
}
