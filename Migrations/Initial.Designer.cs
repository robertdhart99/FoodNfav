// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using FoodFavorites.Models;

namespace FoodFavorites.Migrations
{
    [DbContext(typeof(FoodContext))]
    [Migration("20211204162905_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodFavorites.Models.Genre", b =>
                {
                    b.Property<string>("GenreID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreID = "brk",
                            Name = "Breakfast"
                        },
                        new
                        {
                            GenreID = "lun",
                            Name = "Lunch"
                        },
                        new
                        {
                            GenreID = "din",
                            Name = "Dinner"
                        },
                        new
                        {
                            GenreID = "snk",
                            Name = "Snack"
                        });
                });

            modelBuilder.Entity("FoodFavorites.Models.Member", b =>
                {
                    b.Property<string>("MemberID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberID");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            MemberID = "bur",
                            Name = "Burdhan Srishant"
                        },
                        new
                        {
                            MemberID = "che",
                            Name = "Chen Zilong "
                        },
                        new
                        {
                            MemberID = "pok",
                            Name = "Pokhrel Bhakti"
                        },
                        new
                        {
                            MemberID = "har",
                            Name = "Hart Robert"        
                        });
                });

            modelBuilder.Entity("FoodFavorites.Models.Foods", b =>
                {
                    b.Property<string>("FoodID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GenreID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FoodID");

                    b.HasIndex("GenreID");

                    b.HasIndex("MemberID");

                    b.ToTable("Foods");

                    b.HasData(
                    new
                    {
                        //Srishant
                        FoodID = "omel",
                        GenreID = "brk",
                        LogoImage = "omel.png",
                        MemberID = "bur",
                        Name = "Omelette"
                    },
                    new
                    {
                        //Srishant
                        FoodID = "stek",
                        GenreID = "lun",
                        LogoImage = "steak.png",
                        MemberID = "bur",
                        Name = "Steak"
                    },
                    new
                    {
                        //Srishant
                        FoodID = "biry",
                        GenreID = "din",
                        LogoImage = "biryani.png",
                        MemberID = "bur",
                        Name = "Biryani"
                    },
                    new
                    {
                        //Srishant
                        FoodID = "sandwich",
                        GenreID = "snk",
                        LogoImage = "sandwich.png",
                        MemberID = "bur",
                        Name = "Sandwich"
                    },

                    new
                    {
                        //Robert Hart
                        FoodID = "westerno",
                        GenreID = "brk",
                        LogoImage = "western_omelette.png",
                        MemberID = "har",
                        Name = "Western Omelette"
                    },
                    new
                    {
                        //Robert Hart
                        FoodID = "frenchd",
                        GenreID = "lun",
                        LogoImage = "french_dip.png",
                        MemberID = "har",
                        Name = "French Dip"
                    },
                    new
                    {
                        //Robert Hart
                        FoodID = "gporkc",
                        GenreID = "din",
                        LogoImage = "glazed_pork_chops.png",
                        MemberID = "har",
                        Name = "Glazed Pork Chops"
                    },
                    new
                    {
                        //Robert Hart
                        FoodID = "tortc",
                        GenreID = "snk",
                        LogoImage = "tortilla_chips.png",
                        MemberID = "har",
                        Name = "Tortilla Chips"
                    },
                    new
                    {
                        //Zilong
                        FoodID = "steamb",
                        GenreID = "brk",
                        LogoImage = "steamed_bun.png",
                        MemberID = "che",
                        Name = "Steamed Bun"
                    },
                    new
                    {
                        //Zilong
                        FoodID = "fcarroty",
                        GenreID = "lun",
                        LogoImage = "fried_carrot_with_yam.png",
                        MemberID = "che",
                        Name = "Fried Carrot with Yam"
                    },
                    new
                    {
                        //Zilong
                        FoodIDD = "sweetnscarp",
                        GenreID = "din",
                        LogoImage = "sweet_and_sour_carp.png",
                        MemberID = "che",
                        Name = "Sweet and Sour Carp"
                    },
                    new
                    {
                        //Zilong
                        FoodID = "cooki",
                        GenreID = "snk",
                        LogoImage = "cookie.png",
                        MemberID = "che",
                        Name = "Cookie"
                    },
                    new
                    {
                        //Bhakti
                        FoodID = "bec",
                        GenreID = "brk",
                        LogoImage = "egg_sandwich.png",
                        MemberID = "pok",
                        Name = "Bacon Egg and Cheese sandwich"
                    },
                    new
                    {
                        //Bhakti
                        FoodID = "curry",
                        GenreID = "lun",
                        LogoImage = "curry.png",
                        MemberID = "pok",
                        Name = "Curry"
                    },
                    new
                    {
                        //Bhakti
                        FoodID = "momo",
                        GenreID = "din",
                        LogoImage = "momo.png",
                        MemberID = "pok",
                        Name = "Momo"
                    },
                    new
                    {
                        //Bhakti
                        FoodID = "chatepate",
                        GenreID = "snk",
                        LogoImage = "chatepate.png",
                        MemberID = "pok",
                        Name = "Chatepate"
                    });

                });

            modelBuilder.Entity("FoodFavorites.Models.Foods", b =>
                {
                    b.HasOne("FoodFavorites.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID");

                    b.HasOne("FoodFavorites.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID");
                });
#pragma warning restore 612, 618
        }
    }
}
