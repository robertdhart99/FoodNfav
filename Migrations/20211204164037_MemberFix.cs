using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodFavorites.Migrations
{
    public partial class MemberFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "anchor",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "arsenic",
                column: "MemberID",
                value: "bro");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "black",
                column: "MemberID",
                value: "bea");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "blonde",
                column: "MemberID",
                value: "bea");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "castle",
                column: "MemberID",
                value: "bro");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "dodgeball",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "dragon",
                column: "MemberID",
                value: "bea");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fail",
                column: "MemberID",
                value: "bro");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "fast",
                column: "MemberID",
                value: "bea");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "long",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "nemo",
                column: "MemberID",
                value: "bea");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "October",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "pirates",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "princess",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "santa",
                column: "MemberID",
                value: "bro");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "saving",
                column: "MemberID",
                value: "bro");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "shrek",
                column: "MemberID",
                value: "emi");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "shrek2",
                column: "MemberID",
                value: "emi");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "shrek3",
                column: "MemberID",
                value: "emi");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "shrek4",
                column: "MemberID",
                value: "emi");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "silent",
                column: "MemberID",
                value: "emi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "anchor",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "arsenic",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "black",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "blonde",
                column: "MemberID",
                value: null);

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

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "shrek",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "shrek2",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "shrek3",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "shrek4",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodID",
                keyValue: "silent",
                column: "MemberID",
                value: null);
        }
    }
}
