using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodFavorites.Migrations
{
    public partial class _5PicsEa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "westerno");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "frenchd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[] { "westerno", "brk", "western_omelette.png", "har", "Western Omelette" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[] { "frenchd", "lun", "french_dip.png", "har", "French Dip" });
        }
    }
}
