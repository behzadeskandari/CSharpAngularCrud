using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "behzad", "eskandari" },
                    { 33, "hasan", "vedadi" },
                    { 34, "abbas", "vedadi" },
                    { 35, "reza", "javani" },
                    { 36, "mehdi", "javani" },
                    { 37, "hasan", "javani" },
                    { 38, "majid", "javani" },
                    { 39, "javad", "javani" },
                    { 40, "mehdi", "javani" },
                    { 41, "morteza", "javani" },
                    { 42, "mojtaba", "javani" },
                    { 43, "amir", "javani" },
                    { 44, "ali", "javani" },
                    { 32, "majid", "vedadi" },
                    { 45, "amirhosen", "javani" },
                    { 47, "pejman", "javani" },
                    { 48, "parham", "javani" },
                    { 49, "john", "doe" },
                    { 50, "Jack", "doe" },
                    { 51, "hasan", "revvandi" },
                    { 52, "reza", "revvandi" },
                    { 53, "mehdi", "revvandi" },
                    { 54, "majid", "revvandi" },
                    { 55, "abas", "revvandi" },
                    { 56, "banfshe", "revvandi" },
                    { 57, "asal", "revvandi" },
                    { 58, "maryam", "revvandi" },
                    { 46, "saeed", "javani" },
                    { 31, "jaavad", "vedadi" },
                    { 30, "reza", "vedadi" },
                    { 29, "behzad", "vedadi" },
                    { 2, "majid", "majidi" },
                    { 3, "hasan", "hasani" },
                    { 4, "reza", "nazari" },
                    { 5, "hasan", "nazari" },
                    { 6, "nazari", "majid" },
                    { 7, "reza", "nazari" },
                    { 8, "javad", "nazari" },
                    { 9, "behzad", "behzadi" },
                    { 10, "reza", "majidi" },
                    { 11, "hasan", "majidi" },
                    { 12, "abas", "majidi" }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 13, "reza", "majidi" },
                    { 14, "mehdi", "majidi" },
                    { 15, "javad", "majidi" },
                    { 16, "nabi", "majidi" },
                    { 17, "asghar", "majidi" },
                    { 18, "frozan", "frozan" },
                    { 19, "mehdi", "frozan" },
                    { 20, "behzad", "frozan" },
                    { 21, "reza", "frozan" },
                    { 22, "majid", "frozan" },
                    { 23, "javad", "frozan" },
                    { 24, "keyval", "frozan" },
                    { 25, "ali", "frozan" },
                    { 26, "ali", "vedadi" },
                    { 27, "keyvan", "vedadi" },
                    { 28, "hesam", "vedadi" },
                    { 59, "bahare", "revvandi" },
                    { 60, "majidreza", "revvandi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
