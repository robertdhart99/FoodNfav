using Microsoft.EntityFrameworkCore;


namespace FoodFavorites.Models
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options)
            : base(options)
        { }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreID = "brk", Name = "Breakfast"},
                new Genre { GenreID = "lun", Name = "Lunch" }, 
                new Genre { GenreID = "din", Name = "Dinner" }, 
                new Genre { GenreID = "snk", Name = "Snack" }
            );                                                                              // enter in the major, Year, Bio 
            modelBuilder.Entity<Member>().HasData(
                new Member { MemberID = "bur", Name = "Srishant Burdhan", Major = "Enter Major Here", Year = "Enter year Here", Bio = "Enter BIO HERE" },
                new Member { MemberID = "che", Name = "Zilong Chen", Major = "Enter Major Here", Year = "Enter year Here", Bio = "Enter BIO HERE" },
                new Member { MemberID = "pok", Name = "Bhakti Pokhrel",Major = "Enter Major Here", Year = "Enter year Here", Bio = "Enter BIO HERE" },
                new Member { MemberID = "har", Name = "Robert Hart", Major = "Information Techology - Software Development || Cyber Security", Year = "Senior", Bio = "I prefer to go by Bobby. I will be graduating in august with my IT software dev and cybersecurity degrees. I love to sail and hope to one day Sail around the world." } 
                
            );
            modelBuilder.Entity<Food>().HasData(


               //Srishant   - swap out foodID,Name & the IMG reference for your foods img reference. 
               new { FoodID = "hotdog", Name = "Srishant breakfast food name here", GenreID = "brk", MemberID = "bur", LogoImage = "shrek.png" },
               new { FoodID = "shrek2", Name = "Srishant lunch food name here", GenreID = "lun", MemberID = "bur", LogoImage = "shrek_2.png" },
               new { FoodID = "shrek3", Name = "Srishant Dinner food name here", GenreID = "din", MemberID = "bur", LogoImage = "shrek_3.png" },
               new { FoodID = "shrek4", Name = "Srishant Snack food name here", GenreID = "snk", MemberID = "bur", LogoImage = "shrek_4.png" },

               //Robert - swap out foodID,Name & the IMG reference for your foods img reference. 
               new { FoodID = "westerno", Name = "Western Omelette", GenreID = "brk", MemberID = "har", LogoImage = "western_omelette.png" },
               new { FoodID = "frenchd", Name = "French Dip", GenreID = "lun", MemberID = "har", LogoImage = "french_dip.png" },
               new { FoodID = "gporkc", Name = "Glazed Pork Chops", GenreID = "din", MemberID = "har", LogoImage = "glazed_pork_chops.png" },
               new { FoodID = "tortc", Name = "Tortilla Chips", GenreID = "snk", MemberID = "har", LogoImage = "tortilla_chips.png" },

               //Zilong- swap out foodID,Name & the IMG reference for your foods img reference. 
               new { FoodID = "burger", Name = "Zilong breakfast food name here", GenreID = "brk", MemberID = "che", LogoImage = "castle_cagliostro.png" },
               new { FoodID = "fail", Name = "Zilong lunch food name here", GenreID = "lun", MemberID = "che", LogoImage = "fail_safe_64.png" },
               new { FoodID = "saving", Name = "Zilong Dinner food name here", GenreID = "din", MemberID = "che", LogoImage = "saving_private_ryan.png" },
               new { FoodID = "arsenic", Name = "Zilong snack food name here", GenreID = "snk", MemberID = "che", LogoImage = "arsenic_old_lace.png" },

               //Bhakti   - swap out foodID,Name & the IMG reference for your foods img reference. 
               new { FoodID = "cheese", Name = "Bhakti breakfast food name here", GenreID = "brk", MemberID = "pok", LogoImage = "2_fast_2_furious.png" },
               new { FoodID = "nemo", Name = "Bhakti lunch food name here", GenreID = "lun", MemberID = "pok", LogoImage = "finding_nemo.png" }, 
               new { FoodID = "black", Name = "Bhakti dinner food name here", GenreID = "din", MemberID = "pok", LogoImage = "black_panther.png" }, 
               new { FoodID = "blonde", Name = "Bhakti snack food name here", GenreID = "snk", MemberID = "pok", LogoImage = "legally_blonde.png" }

           );
        }
    }
}
