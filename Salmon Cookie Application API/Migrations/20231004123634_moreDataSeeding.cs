using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Salmon_Cookie_Application_API.Migrations
{
    /// <inheritdoc />
    public partial class moreDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HourlySale",
                columns: new[] { "ID", "CookieStandID", "SalePerHour" },
                values: new object[,]
                {
                    { 11, 1, 17 },
                    { 12, 1, 11 },
                    { 13, 1, 19 },
                    { 14, 1, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 14);
        }
    }
}
