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
                values: new object[] { "I go by Sri for short as my name is sometimes hard to pronounce. I graduate around 2 years later with qualifications in Software Dev and Data Tech. I love playing soccer as I have played it professionally and casually as well. Along with all of that, I am an aspiring gamer/streamer and I really hope I can make a side gig out of this interest.", "Information Techology", "Senior" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "che",
                columns: new[] { "Bio", "Major", "Name", "Year" },
                values: new object[] { "I'm a Zilong Chen BIO (about us) ", "Information Techology - Software Development", "Zilong Chen", "Junior" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "pok",
                columns: new[] { "Bio", "Major", "Name", "Year" },
                values: new object[] { "I am Bhakti Pokhrel and I love to watch and play soccer", "Information Techology Software Develepment", "Bhakti Pokhrel", "Junior" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "har",
                columns: new[] { "Bio", "Major", "Year" },
                values: new object[] { "I prefer to go by Bobby. I will be graduating in august with my IT software dev and cybersecurity degrees. I love to sail and hope to one day Sail around the worlddd.", "Information Techology - Software Development || Cyber Security", "Senior" });
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
