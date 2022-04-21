using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies7.Migrations
{
    public partial class Pictures : Migration
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

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "arsenic",
                column: "LogoImage",
                value: "arsenic_old_lace.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "black",
                column: "LogoImage",
                value: "black_panther.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "blonde",
                column: "LogoImage",
                value: "legally_blonde.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "castle",
                column: "LogoImage",
                value: "castle_cagliostro.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "dragon",
                column: "LogoImage",
                value: "db_super_broly.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "fail",
                column: "LogoImage",
                value: "fail_safe_64.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "fast",
                column: "LogoImage",
                value: "2_fast_2_furious.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "long",
                column: "LogoImage",
                value: "longest_yard.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "nemo",
                column: "LogoImage",
                value: "finding_nemo.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "October",
                column: "LogoImage",
                value: "october_sky.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "pirates",
                column: "LogoImage",
                value: "pirates_caribbean.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "princess",
                column: "LogoImage",
                value: "princess_bride.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "santa",
                column: "LogoImage",
                value: "santa_clause.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "saving",
                column: "LogoImage",
                value: "saving_private_ryan.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek",
                column: "LogoImage",
                value: "shrek.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek2",
                column: "LogoImage",
                value: "shrek_2.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek3",
                column: "LogoImage",
                value: "shrek_3.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek4",
                column: "LogoImage",
                value: "shrek_4.png");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "silent",
                column: "LogoImage",
                value: "silent_hill.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "arsenic",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "black",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "blonde",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "castle",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "dragon",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "fail",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "fast",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "long",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "nemo",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "October",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "pirates",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "princess",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "santa",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "saving",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek2",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek3",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek4",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "silent",
                column: "LogoImage",
                value: "");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[,]
                {
                    { "dodgeball", "com", "", "har", "Dodgeball" },
                    { "anchor", "com", "", "har", "Anchor Man" }
                });
        }
    }
}
