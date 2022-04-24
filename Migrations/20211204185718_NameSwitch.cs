using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodFavorites.Migrations
{
    public partial class NameSwitch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "bur",
                column: "Name",
                value: "Srishant Burdhan");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "che",
                column: "Name",
                value: "Zilong Chen");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "pok",
                column: "Name",
                value: "Bhakti Pokhrel");


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
                keyValue: "bur",
                column: "Name",
                value: "Burdhan Srishant");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "che",
                column: "Name",
                value: "Chen Zilong");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "pok",
                column: "Name",
                value: "Pokhrel Bhakti");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "har",
                column: "Name",
                value: "Hart Robert");
        }
    }
}
