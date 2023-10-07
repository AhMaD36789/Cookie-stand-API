using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Salmon_Cookie_Application_API.Migrations
{
    /// <inheritdoc />
    public partial class addedCustomerPerHour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerPerHour",
                table: "HourlySale",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 1,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 2,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 3,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 4,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 5,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 6,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 7,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 8,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 9,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 10,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 11,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 12,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 13,
                column: "CustomerPerHour",
                value: 0);

            migrationBuilder.UpdateData(
                table: "HourlySale",
                keyColumn: "ID",
                keyValue: 14,
                column: "CustomerPerHour",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerPerHour",
                table: "HourlySale");
        }
    }
}
