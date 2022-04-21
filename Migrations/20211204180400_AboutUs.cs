using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies7.Migrations
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
                keyValue: "bea",
                columns: new[] { "Bio", "Major", "Year" },
                values: new object[] { "I like cars, watching anime and playing video games", "Information Techology", "Senior" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "bro",
                columns: new[] { "Bio", "Major", "Name", "Year" },
                values: new object[] { "I'm a nerd.", "Information Techology - Software Development", "Brown Chris", "Junior" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "dan",
                columns: new[] { "Bio", "Major", "Name", "Year" },
                values: new object[] { "I am Ibukun Daniel but I also go by I.B.K", "Information Techology - Software Development || CS minor", "Daniel Ibukun", "Junior" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "emi",
                columns: new[] { "Bio", "Major", "Year" },
                values: new object[] { "I'm a weeb and a furry.", "Information Techology - Software Development", "Junior" });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "har",
                columns: new[] { "Bio", "Major", "Year" },
                values: new object[] { "I am Robert Hart but I go by Bobby. I am about to finish my IT software dev and cybersecurity degrees. I love spending time outdoors but also like playing games.", "Information Techology - Software Development || Cyber Security", "Senior" });
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
                keyValue: "bro",
                column: "Name",
                value: "Brown Chistopher");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "dan",
                column: "Name",
                value: "Daniel Ibukunoluwa");
        }
    }
}
