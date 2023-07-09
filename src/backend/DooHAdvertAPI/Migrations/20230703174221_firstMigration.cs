using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DooHAdvertAPI.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Path = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    CityName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "Id", "CityName", "EndTime", "Path", "Priority", "StartTime" },
                values: new object[,]
                {
                    { 1, "London", new DateTime(2023, 7, 6, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/AeroTech Drones", 9, new DateTime(2023, 7, 3, 18, 42, 21, 119, DateTimeKind.Local).AddTicks(3632) },
                    { 2, "Bournemouth", new DateTime(2023, 7, 8, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/HumblePies", 4, new DateTime(2023, 7, 2, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Sheffield", new DateTime(2023, 7, 8, 7, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/Java Coffee", 6, new DateTime(2023, 7, 3, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Manchester", new DateTime(2023, 7, 9, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/LNN", 6, new DateTime(2023, 7, 4, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Leeds", new DateTime(2023, 7, 10, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/LumoThread", 2, new DateTime(2023, 7, 5, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Liverpool", new DateTime(2023, 7, 11, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/MackyCs", 5, new DateTime(2023, 7, 6, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Brighton", new DateTime(2023, 7, 11, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/Solaris Solar", 2, new DateTime(2023, 7, 6, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Hove", new DateTime(2023, 7, 11, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/Solaris Solar", 9, new DateTime(2023, 7, 3, 18, 42, 21, 119, DateTimeKind.Local).AddTicks(3714) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");
        }
    }
}
