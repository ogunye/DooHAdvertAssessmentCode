using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DooHAdvertAPI.Migrations
{
    /// <inheritdoc />
    public partial class firstSeededMigrationDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adverts_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "London" },
                    { 2, "Bournemouth" },
                    { 3, "Sheffield" },
                    { 4, "Manchester" },
                    { 5, "Leeds" },
                    { 6, "Liverpool" },
                    { 7, "Brighton" },
                    { 8, "Hove" }
                });

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "Id", "CityId", "EndTime", "Path", "Priority", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 6, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/AeroTech Drones", 9, new DateTime(2023, 7, 2, 22, 9, 37, 233, DateTimeKind.Local).AddTicks(7745) },
                    { 2, 3, new DateTime(2023, 7, 8, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/HumblePies", 4, new DateTime(2023, 7, 2, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2023, 7, 8, 7, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/Java Coffee", 6, new DateTime(2023, 7, 3, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2023, 7, 9, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/LNN", 6, new DateTime(2023, 7, 4, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2023, 7, 10, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/LumoThread", 2, new DateTime(2023, 7, 5, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, new DateTime(2023, 7, 11, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/MackyCs", 5, new DateTime(2023, 7, 6, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(2023, 7, 11, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/Solaris Solar", 2, new DateTime(2023, 7, 6, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, new DateTime(2023, 7, 11, 5, 10, 0, 0, DateTimeKind.Unspecified), "Resources/Images/Solaris Solar", 9, new DateTime(2023, 7, 2, 22, 9, 37, 233, DateTimeKind.Local).AddTicks(7813) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_CityId",
                table: "Adverts",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
