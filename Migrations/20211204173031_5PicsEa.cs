using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies7.Migrations
{
    public partial class _5PicsEa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "anchor");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "dodgeball");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[] { "anchor", "com", "anchor_man.png", "har", "Anchor Man" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[] { "dodgeball", "com", "dodgeball.png", "har", "Dodgeball" });
        }
    }
}
