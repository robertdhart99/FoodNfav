using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodFavorites.Migrations
{
    public partial class IBK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[,]
                {
                    { "anchor", "com", "anchor_man.png", "har", "Anchor Man" },
                    { "dodgeball", "com", "dodgeball.png", "har", "Dodgeball" },
                    { "rn", "act", "red_notice.png", "dan", "Red Notice" },
                    { "hog", "dra", "house_gucci.png", "dan", "House of Gucci" },
                    { "ttb", "dra", "train_to_busan.png", "dan", "Train to Busan" },
                    { "par", "hor", "parasite.png", "dan", "Parasite" },
                    { "free", "com", "free_guy.png", "dan", "Free Guy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "anchor");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "dodgeball");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "free");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "hog");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "par");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "rn");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "ttb");
        }
    }
}
