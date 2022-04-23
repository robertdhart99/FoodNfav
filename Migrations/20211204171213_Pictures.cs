using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodFavorites.Migrations
{
    public partial class Pictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "ancor");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "dodgeball");
            //robert

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "westerno",
                column: "LogoImage",
                value: "western_omelette.png");

            migrationBuilder.UpdateData(
               table: "Foods",
               keyColumn: "FoodID",
               keyValue: "frenchd",
               column: "LogoImage",
               value: "french_dip.png");

            migrationBuilder.UpdateData(
               table: "Foods",
               keyColumn: "FoodID",
               keyValue: "gporkc",
               column: "LogoImage",
               value: "glazed_pork_chops.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "tortc",
                column: "LogoImage",
                value: "tortilla_chips.png");

            //Srishant
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "blonde",
                column: "LogoImage",
                value: "legally_blonde.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "castle",
                column: "LogoImage",
                value: "castle_cagliostro.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "dragon",
                column: "LogoImage",
                value: "db_super_broly.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fail",
                column: "LogoImage",
                value: "fail_safe_64.png");

            //Zilong
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fast",
                column: "LogoImage",
                value: "2_fast_2_furious.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "long",
                column: "LogoImage",
                value: "longest_yard.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "nemo",
                column: "LogoImage",
                value: "finding_nemo.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "October",
                column: "LogoImage",
                value: "october_sky.png");

            //Bhakti
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "pirates",
                column: "LogoImage",
                value: "pirates_caribbean.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "princess",
                column: "LogoImage",
                value: "princess_bride.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "santa",
                column: "LogoImage",
                value: "santa_clause.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "saving",
                column: "LogoImage",
                value: "saving_private_ryan.png");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //robert
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "westerno",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "frenchd",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "gporkc",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "tortc",
                column: "LogoImage",
                value: "");

            //Srishant
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "dragon",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fail",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fast",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "long",
                column: "LogoImage",
                value: "");

            //Zilong
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "nemo",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "October",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "pirates",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "princess",
                column: "LogoImage",
                value: "");

            //Bhakti
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "santa",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "saving",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "shrek",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "shrek2",
                column: "LogoImage",
                value: "");

            /*migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[,]
                {
                    { "dodgeball", "com", "", "har", "Dodgeball" },
                    { "anchor", "com", "", "har", "Anchor Man" }
                });*/
        }
    }
}
