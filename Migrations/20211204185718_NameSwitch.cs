using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies7.Migrations
{
    public partial class NameSwitch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "bea",
                column: "Name",
                value: "Chevaux Beasley");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "bro",
                column: "Name",
                value: "Chris Brown");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "dan",
                column: "Name",
                value: "Ibukun Daniel");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "emi",
                column: "Name",
                value: "Emily Hempker");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "har",
                column: "Name",
                value: "Robert Hart");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "bea",
                column: "Name",
                value: "Beasley Chevaux");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "bro",
                column: "Name",
                value: "Brown Chris");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "dan",
                column: "Name",
                value: "Daniel Ibukun");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "emi",
                column: "Name",
                value: "Hempker Emily");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "har",
                column: "Name",
                value: "Hart Robert");
        }
    }
}
