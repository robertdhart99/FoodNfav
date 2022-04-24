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
                keyValue: "westerno");

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "frenchd"); 
            
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
                keyValue: "omel",
                column: "LogoImage",
                value: "omel.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "stek",
                column: "LogoImage",
                value: "steak.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "biry",
                column: "LogoImage",
                value: "biryani.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "sandwich",
                column: "LogoImage",
                value: "sandwich.png");

            //Zilong
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "steamb",
                column: "LogoImage",
                value: "steamed_bun.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fcarroty",
                column: "LogoImage",
                value: "fried_carrot_with_yam.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "sweetnscarp",
                column: "LogoImage",
                value: "sweet_and_sour_carp.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "cooki",
                column: "LogoImage",
                value: "cookie.png");

            //Bhakti
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "bec",
                column: "LogoImage",
                value: "egg_sandwich.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "curry",
                column: "LogoImage",
                value: "curry.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "momo",
                column: "LogoImage",
                value: "momo.png");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "chatepate",
                column: "LogoImage",
                value: "chatepate.png");

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
                keyValue: "omel",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "stek",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "biry",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "sandwich",
                column: "LogoImage",
                value: "");

            //Zilong
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "steamb",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fcarroty",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "sweetnscarp",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "cooki",
                column: "LogoImage",
                value: "");

            //Bhakti
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "bec",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "curry",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "momo",
                column: "LogoImage",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "chatepate",
                column: "LogoImage",
                value: "");
            
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[,]
                {
                    { "westerno", "brk", "", "har", "Western Omelette" },
                    { "frenchd", "lun", "", "har", "French Dip" }
                });
        }
    }
}
