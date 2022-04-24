using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodFavorites.Migrations
{
    public partial class MemberFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Robert Hart
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "westerno",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "frenchd",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "gporkc",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "tortc",
                column: "MemberID",
                value: "har");

            //Srishant
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "omel",
                column: "MemberID",
                value: "bur");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "stek",
                column: "MemberID",
                value: "bur");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "biry",
                column: "MemberID",
                value: "bur");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "biryani",
                column: "MemberID",
                value: "bur");

            //Zilong
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "steamb",
                column: "MemberID",
                value: "che");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fcarroty",
                column: "MemberID",
                value: "che");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "sweetnscarp",
                column: "MemberID",
                value: "che");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "cooki",
                column: "MemberID",
                value: "che");

            //Bhakti
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "bec",
                column: "MemberID",
                value: "pok");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "curry",
                column: "MemberID",
                value: "pok");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "momo",
                column: "MemberID",
                value: "pok");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "chatepate",
                column: "MemberID",
                value: "pok");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //robert 
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "westerno",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "frenchd",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "gporkc",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "tortc",
                column: "MemberID",
                value: null);

            //Srishant
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "omel",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "stek",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "biry",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "sandwich",
                column: "MemberID",
                value: null);

            //Zilong
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "steamb",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fcarroty",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "sweetnscarp",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "cooki",
                column: "MemberID",
                value: null);

            //Bhakti
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "bec",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "curry",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "momo",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "chatepate",
                column: "MemberID",
                value: null);

        }
    }
}
