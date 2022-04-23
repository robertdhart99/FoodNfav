﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using FoodFavorites.Models;

namespace FoodFavorites.Migrations
{
    [DbContext(typeof(FoodContext))]
    [Migration("20211204164037_MemberFix")]
    partial class MemberFix
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
                            GenreID = "com",
                            Name = "Comedy"
                        },
                        new
                        {
                            GenreID = "hor",
                            Name = "Horror"
                        },
                        new
                        {
                            GenreID = "act",
                            Name = "Action"
                        },
                        new
                        {
                            GenreID = "dra",
                            Name = "Drama"
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
                            MemberID = "bea",
                            Name = "Beasley Chevaux"
                        },
                        new
                        {
                            MemberID = "bro",
                            Name = "Brown Chistopher"
                        },
                        new
                        {
                            MemberID = "dan",
                            Name = "Daniel Ibukunoluwa"
                        },
                        new
                        {
                            MemberID = "har",
                            Name = "Hart Robert"
                        },
                        new
                        {
                            MemberID = "emi",
                            Name = "Hempker Emily"
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

                    b.ToTable("FoodsTable");

                    b.HasData(
                        new
                        {
                            MovieID = "shrek",
                            GenreID = "com",
                            LogoImage = "",
                            MemberID = "emi",
                            Name = "Shrek"
                        },
                        new
                        {
                            MovieID = "shrek2",
                            GenreID = "com",
                            LogoImage = "",
                            MemberID = "emi",
                            Name = "Shrek 2"
                        },
                        new
                        {
                            MovieID = "shrek3",
                            GenreID = "com",
                            LogoImage = "",
                            MemberID = "emi",
                            Name = "Shrek 3"
                        },
                        new
                        {
                            MovieID = "shrek4",
                            GenreID = "com",
                            LogoImage = "",
                            MemberID = "emi",
                            Name = "Shrek 4"
                        },
                        new
                        {
                            MovieID = "silent",
                            GenreID = "hor",
                            LogoImage = "",
                            MemberID = "emi",
                            Name = "Silent Hill"
                        },
                        new
                        {
                            MovieID = "long",
                            GenreID = "com",
                            LogoImage = "",
                            MemberID = "har",
                            Name = "Longest Yard"
                        },
                        new
                        {
                            MovieID = "pirates",
                            GenreID = "act",
                            LogoImage = "",
                            MemberID = "har",
                            Name = "Pirates of the Caribbean"
                        },
                        new
                        {
                            MovieID = "October",
                            GenreID = "dra",
                            LogoImage = "",
                            MemberID = "har",
                            Name = "October Sky"
                        },
                        new
                        {
                            MovieID = "princess",
                            GenreID = "dra",
                            LogoImage = "",
                            MemberID = "har",
                            Name = "Princess Bride"
                        },
                        new
                        {
                            MovieID = "anchor",
                            GenreID = "com",
                            LogoImage = "",
                            MemberID = "har",
                            Name = "Anchor Man"
                        },
                        new
                        {
                            MovieID = "dodgeball",
                            GenreID = "com",
                            LogoImage = "",
                            MemberID = "har",
                            Name = "Dodgeball"
                        },
                        new
                        {
                            MovieID = "castle",
                            GenreID = "act",
                            LogoImage = "",
                            MemberID = "bro",
                            Name = "Castle Cagliostro"
                        },
                        new
                        {
                            MovieID = "fail",
                            GenreID = "hor",
                            LogoImage = "",
                            MemberID = "bro",
                            Name = "Fail Safe"
                        },
                        new
                        {
                            MovieID = "saving",
                            GenreID = "act",
                            LogoImage = "",
                            MemberID = "bro",
                            Name = "Saving Private Ryan"
                        },
                        new
                        {
                            MovieID = "arsenic",
                            GenreID = "hor",
                            LogoImage = "",
                            MemberID = "bro",
                            Name = "Arsenic and Old Lace"
                        },
                        new
                        {
                            MovieID = "santa",
                            GenreID = "com",
                            LogoImage = "",
                            MemberID = "bro",
                            Name = "The Santa Clause"
                        },
                        new
                        {
                            MovieID = "fast",
                            GenreID = "act",
                            LogoImage = "",
                            MemberID = "bea",
                            Name = "2 Fast 2 Furious"
                        },
                        new
                        {
                            MovieID = "nemo",
                            GenreID = "com",
                            LogoImage = "",
                            MemberID = "bea",
                            Name = "Finding Nemo"
                        },
                        new
                        {
                            MovieID = "black",
                            GenreID = "act",
                            LogoImage = "",
                            MemberID = "bea",
                            Name = "Black Panther"
                        },
                        new
                        {
                            MovieID = "blonde",
                            GenreID = "com",
                            LogoImage = "",
                            MemberID = "bea",
                            Name = "Legally Blonde"
                        },
                        new
                        {
                            MovieID = "dragon",
                            GenreID = "act",
                            LogoImage = "",
                            MemberID = "bea",
                            Name = "Dragon Ball Super"
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
