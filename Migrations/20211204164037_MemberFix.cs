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
                keyValue: "castle",
                column: "MemberID",
                value: "bur");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "dodgeball",
                column: "MemberID",
                value: "bur");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "dragon",
                column: "MemberID",
                value: "bur");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fail",
                column: "MemberID",
                value: "bur");

            //Zilong
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fast",
                column: "MemberID",
                value: "che");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "long",
                column: "MemberID",
                value: "che");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "nemo",
                column: "MemberID",
                value: "che");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "October",
                column: "MemberID",
                value: "che");

            //Bhakti
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "pirates",
                column: "MemberID",
                value: "pok");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "princess",
                column: "MemberID",
                value: "pok");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "santa",
                column: "MemberID",
                value: "pok");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "saving",
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
                keyValue: "castle",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "dodgeball",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "dragon",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fail",
                column: "MemberID",
                value: null);

            //Zilong
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fast",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "long",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "nemo",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "October",
                column: "MemberID",
                value: null);

            //Bhakti
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "pirates",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "princess",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "santa",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "saving",
                column: "MemberID",
                value: null);

        }
    }
}
