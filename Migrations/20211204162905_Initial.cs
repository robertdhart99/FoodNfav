using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodFavorites.Migrations
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
                name: "Foods",
                columns: table => new
                {
                    FoodID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GenreID = table.Column<string>(nullable: true),
                    MemberID = table.Column<string>(nullable: true),
                    LogoImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_FoodDataBase_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodDataBase_Members_MemberID",
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
                    { "brk", "Breakfast" },
                    { "lun", "Lunch" },
                    { "din", "Dinner" },
                    { "snk", "Snack" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberID", "Name" },
                values: new object[,]
                {
                    { "bur", "Burdhan Srishant" },
                    { "che", "Chen Zilong" },
                    { "pok", "Pokhrel Bhakti" },
                    { "har", "Hart Robert" }            
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "GenreID", "LogoImage", "MemberID", "Name" },
                values: new object[,]
                {
                    //Srishant
                    { "shrek", "com", "", null, "Shrek" },
                    { "dragon", "act", "", null, "Dragon Ball Super" },
                    { "black", "act", "", null, "Black Panther" },
                    { "fast", "act", "", null, "2 Fast 2 Furious" },
                    //Zilong
                    { "saving", "act", "", null, "Saving Private Ryan" },
                    { "castle", "act", "", null, "Castle Cagliostro" },
                    { "pirates", "act", "", null, "Pirates of the Caribbean" },
                    { "arsenic", "hor", "", null, "Arsenic and Old Lace" },
                    //Bhakti
                    { "fail", "hor", "", null, "Fail Safe" },
                    { "October", "dra", "", null, "October Sky" },
                    { "silent", "hor", "", null, "Silent Hill" },
                    { "nemo", "com", "", null, "Finding Nemo" },
                    //robert
                    { "westerno", "brk", "", null, "Western Omelette" },
                    { "frenchd", "lun", "", null, "French Dip" },
                    { "gporkc", "din", "", null, "Glazed Pork Chops" },
                    { "tortc", "snk", "", null, "Tortilla Chips" }
                });
                     
            migrationBuilder.CreateIndex(
                name: "IX_Foods_GenreID",
                table: "Foods",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_MemberID",
                table: "Foods",
                column: "MemberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
