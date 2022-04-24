using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodFavorites.Migrations
{
    public partial class AboutUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Members",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "bur",
                columns: new[] { "Bio", "Major", "Year" },
                values: new object[] { "I am Srishant BIO", "Information Techology", "Senior" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "che",
                columns: new[] { "Bio", "Major", "Name", "Year" },
                values: new object[] { "I'm a Zilong Chen BIO ", "Information Techology - Software Development", "Chen Zilong", "Junior" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "pok",
                columns: new[] { "Bio", "Major", "Name", "Year" },
                values: new object[] { "I am Bhakti pokhrel Bio", "Information Techology Test", "Pokhrel Bhakti", "Junior" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "har",
                columns: new[] { "Bio", "Major", "Year" },
                values: new object[] { "I prefer to go by Bobby. I will be graduating in august with my IT software dev and cybersecurity degrees. I love to sail and hope to one day Sail around the world.", "Information Techology - Software Development || Cyber Security", "Senior" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Major",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Members");

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
        }
    }
}
