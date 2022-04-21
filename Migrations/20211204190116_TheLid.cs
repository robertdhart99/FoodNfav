using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies7.Migrations
{
    public partial class TheLid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "dan",
                column: "Bio",
                value: "I am groot");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "har",
                column: "Bio",
                value: "I go by Bobby. I am about to finish my IT software dev and cybersecurity degrees. I love spending time outdoors but also like playing games.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "dan",
                column: "Bio",
                value: "I am Ibukun Daniel but I also go by I.B.K");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "MemberID",
                keyValue: "har",
                column: "Bio",
                value: "I am Robert Hart but I go by Bobby. I am about to finish my IT software dev and cybersecurity degrees. I love spending time outdoors but also like playing games.");
        }
    }
}
