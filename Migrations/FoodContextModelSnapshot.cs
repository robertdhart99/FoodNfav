﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using FoodFavorites.Models;

namespace FoodFavorites.Migrations
{
    [DbContext(typeof(FoodContext))]
    partial class FoodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Major")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberID");

                    b.ToTable("Members");

                b.HasData(
                    new
                    {
                        MemberID = "bur",
                        Bio = "",
                        Major = "",
                        Name = "Srishant Burdhan",
                        Year = ""
                    },
                    new
                    {
                        MemberID = "che",
                        Bio = "",
                        Major = "",
                        Name = "Zilong Chen",
                        Year = ""
                    },
                    new
                    {
                        MemberID = "pok",
                        Bio = "",
                        Major = "",
                        Name = "Bhakti Pokhrel",
                        Year = ""
                    },
                    new
                    {
                        MemberID = "har",
                        Bio = "I prefer to go by Bobby. I will be graduating in august with my IT software dev and cybersecurity degrees. I love to sail and hope to one day Sail around the world.",
                        Major = "Information Techology - Software Development || Cyber Security",
                        Name = "Robert Hart",
                        Year = "Senior"
                    });     
                       
                });

            modelBuilder.Entity("FoodFavorites.Models.Food", b =>
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
                        FoodID = "shrek",
                        GenreID = "com",
                        LogoImage = "shrek.png",
                        MemberID = "bur",
                        Name = "Shrek"
                    },
                    new
                    {
                        //Srishant
                        FoodID = "shrek2",
                        GenreID = "com",
                        LogoImage = "shrek_2.png",
                        MemberID = "emi",
                        Name = "Shrek 2"
                    },
                    new
                    {
                        //Srishant
                        FoodID = "shrek3",
                        GenreID = "com",
                        LogoImage = "shrek_3.png",
                        MemberID = "emi",
                        Name = "Shrek 3"
                    },
                    new
                    {
                        //Srishant
                        FoodID = "shrek4",
                        GenreID = "com",
                        LogoImage = "shrek_4.png",
                        MemberID = "emi",
                        Name = "Shrek 4"
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
                        FoodID = "castle",
                        GenreID = "act",
                        LogoImage = "castle_cagliostro.png",
                        MemberID = "bro",
                        Name = "Castle Cagliostro"
                    },
                    new
                    {
                        //Zilong
                        FoodID = "fail",
                        GenreID = "hor",
                        LogoImage = "fail_safe_64.png",
                        MemberID = "bro",
                        Name = "Fail Safe"
                    },
                    new
                    {
                        //Zilong
                        FoodIDD = "saving",
                        GenreID = "act",
                        LogoImage = "saving_private_ryan.png",
                        MemberID = "bro",
                        Name = "Saving Private Ryan"
                    },
                    new
                    {
                        //Zilong
                        FoodID = "arsenic",
                        GenreID = "hor",
                        LogoImage = "arsenic_old_lace.png",
                        MemberID = "bro",
                        Name = "Arsenic and Old Lace"
                    },
                    new
                    {
                        //Bhakti
                        FoodID = "santa",
                        GenreID = "com",
                        LogoImage = "santa_clause.png",
                        MemberID = "bro",
                        Name = "The Santa Clause"
                    },
                    new
                    {
                        //Bhakti
                        FoodID = "fast",
                        GenreID = "act",
                        LogoImage = "2_fast_2_furious.png",
                        MemberID = "bea",
                        Name = "2 Fast 2 Furious"
                    },
                    new
                    {
                        //Bhakti
                        FoodID = "nemo",
                        GenreID = "com",
                        LogoImage = "finding_nemo.png",
                        MemberID = "bea",
                        Name = "Finding Nemo"
                    },
                    new
                    {
                        //Bhakti
                        FoodID = "black",
                        GenreID = "act",
                        LogoImage = "black_panther.png",
                        MemberID = "bea",
                        Name = "Black Panther"
                    });
                        
                });

            modelBuilder.Entity("FoodFavorites.Models.Food", b =>
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