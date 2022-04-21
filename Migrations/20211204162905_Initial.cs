using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies7.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GenreID = table.Column<string>(nullable: true),
                    MemberID = table.Column<string>(nullable: true),
                    LogoImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_Members_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Members",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "Name" },
                values: new object[,]
                {
                    { "com", "Comedy" },
                    { "hor", "Horror" },
                    { "act", "Action" },
                    { "dra", "Drama" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberID", "Name" },
                values: new object[,]
                {
                    { "bea", "Beasley Chevaux" },
                    { "bro", "Brown Chistopher" },
                    { "dan", "Daniel Ibukunoluwa" },
                    { "har", "Hart Robert" },
                    { "emi", "Hempker Emily" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[,]
                {
                    { "shrek", "com", "", null, "Shrek" },
                    { "dragon", "act", "", null, "Dragon Ball Super" },
                    { "black", "act", "", null, "Black Panther" },
                    { "fast", "act", "", null, "2 Fast 2 Furious" },
                    { "saving", "act", "", null, "Saving Private Ryan" },
                    { "castle", "act", "", null, "Castle Cagliostro" },
                    { "pirates", "act", "", null, "Pirates of the Caribbean" },
                    { "arsenic", "hor", "", null, "Arsenic and Old Lace" },
                    { "fail", "hor", "", null, "Fail Safe" },
                    { "October", "dra", "", null, "October Sky" },
                    { "silent", "hor", "", null, "Silent Hill" },
                    { "nemo", "com", "", null, "Finding Nemo" },
                    { "santa", "com", "", null, "The Santa Clause" },
                    { "dodgeball", "com", "", null, "Dodgeball" },
                    { "anchor", "com", "", null, "Anchor Man" },
                    { "long", "com", "", null, "Longest Yard" },
                    { "shrek4", "com", "", null, "Shrek 4" },
                    { "shrek3", "com", "", null, "Shrek 3" },
                    { "shrek2", "com", "", null, "Shrek 2" },
                    { "blonde", "com", "", null, "Legally Blonde" },
                    { "princess", "dra", "", null, "Princess Bride" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreID",
                table: "Movies",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MemberID",
                table: "Movies",
                column: "MemberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
