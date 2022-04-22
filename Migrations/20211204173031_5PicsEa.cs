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
                keyValue: "anchor");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "dodgeball");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[] { "anchor", "com", "anchor_man.png", "har", "Anchor Man" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[] { "dodgeball", "com", "dodgeball.png", "har", "Dodgeball" });
        }
    }
}
