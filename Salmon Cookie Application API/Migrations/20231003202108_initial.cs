using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Salmon_Cookie_Application_API.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cookies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinimumCustomerPerHour = table.Column<int>(type: "int", nullable: false),
                    MaximumCustomerPerHour = table.Column<int>(type: "int", nullable: false),
                    AverageCookiesPerSale = table.Column<double>(type: "float", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cookies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HourlySale",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CookieStandID = table.Column<int>(type: "int", nullable: false),
                    SalePerHour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourlySale", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HourlySale_Cookies_CookieStandID",
                        column: x => x.CookieStandID,
                        principalTable: "Cookies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cookies",
                columns: new[] { "ID", "AverageCookiesPerSale", "Description", "Location", "MaximumCustomerPerHour", "MinimumCustomerPerHour", "Owner" },
                values: new object[] { 1, 2.5, "Since 1995", "Zarqa", 10, 3, "Ahmad Mohsen" });

            migrationBuilder.InsertData(
                table: "HourlySale",
                columns: new[] { "ID", "CookieStandID", "SalePerHour" },
                values: new object[,]
                {
                    { 1, 1, 10 },
                    { 2, 1, 15 },
                    { 3, 1, 12 },
                    { 4, 1, 18 },
                    { 5, 1, 25 },
                    { 6, 1, 12 },
                    { 7, 1, 30 },
                    { 8, 1, 23 },
                    { 9, 1, 9 },
                    { 10, 1, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HourlySale_CookieStandID",
                table: "HourlySale",
                column: "CookieStandID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HourlySale");

            migrationBuilder.DropTable(
                name: "Cookies");
        }
    }
}
