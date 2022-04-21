using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies7.Migrations
{
    public partial class IBK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "GenreID", "LogoImage", "MemberID", "Name" },
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
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "anchor");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "dodgeball");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "free");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "hog");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "par");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "rn");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "ttb");
        }
    }
}
