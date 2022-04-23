using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodFavorites.Migrations
{
    public partial class TheLid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "che",
                column: "Bio",
                value: "che description goes here (TheLid migration) ");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "har",
                column: "Bio",
                value: "I prefer to go by Bobby. I will be graduating in august with my IT software dev and cybersecurity degrees. I love to sail and hope to one day Sail around the world.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "che",
                column: "Bio",
                value: "I am Zilong chen test LID");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "har",
                column: "Bio",
                value: "I prefer to go by Bobby. I will be graduating in august with my IT software dev and cybersecurity degrees. I love to sail and hope to one day Sail around the world.");
        }
    }
}
