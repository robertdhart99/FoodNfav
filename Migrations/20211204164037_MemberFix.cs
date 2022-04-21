using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies7.Migrations
{
    public partial class MemberFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "anchor",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "arsenic",
                column: "MemberID",
                value: "bro");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "black",
                column: "MemberID",
                value: "bea");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "blonde",
                column: "MemberID",
                value: "bea");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "castle",
                column: "MemberID",
                value: "bro");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "dodgeball",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "dragon",
                column: "MemberID",
                value: "bea");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "fail",
                column: "MemberID",
                value: "bro");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "fast",
                column: "MemberID",
                value: "bea");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "long",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "nemo",
                column: "MemberID",
                value: "bea");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "October",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "pirates",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "princess",
                column: "MemberID",
                value: "har");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "santa",
                column: "MemberID",
                value: "bro");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "saving",
                column: "MemberID",
                value: "bro");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek",
                column: "MemberID",
                value: "emi");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek2",
                column: "MemberID",
                value: "emi");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek3",
                column: "MemberID",
                value: "emi");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek4",
                column: "MemberID",
                value: "emi");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "silent",
                column: "MemberID",
                value: "emi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "anchor",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "arsenic",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "black",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "blonde",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "castle",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "dodgeball",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "dragon",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "fail",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "fast",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "long",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "nemo",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "October",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "pirates",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "princess",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "santa",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "saving",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek2",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek3",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "shrek4",
                column: "MemberID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: "silent",
                column: "MemberID",
                value: null);
        }
    }
}
