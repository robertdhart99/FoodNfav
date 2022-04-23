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
                new Member { MemberID = "bur", Name = "Srishant Burdhan", Major = "Information Technology - Data Technologies & Software Development", Year = "Sophomore", Bio = "I go by Sri for short as my name is sometimes hard to pronounce. I graduate around 2 years later with qualifications in Software Dev and Data Tech. I love playing soccer as I have played it professionally and casually as well. Along with all of that, I am an aspiring gamer/streamer and I really hope I can make a side gig out of this interest." },
                new Member { MemberID = "che", Name = "Zilong Chen", Major = "Enter Major Here", Year = "Enter year Here", Bio = "Enter BIO HERE" },
                new Member { MemberID = "pok", Name = "Bhakti Pokhrel",Major = "Enter Major Here", Year = "Enter year Here", Bio = "Enter BIO HERE" },
                new Member { MemberID = "har", Name = "Robert Hart", Major = "Information Techology - Software Development || Cyber Security", Year = "Senior", Bio = "I prefer to go by Bobby. I will be graduating in august with my IT software dev and cybersecurity degrees. I love to sail and hope to one day Sail around the world." } 
                
            );
            modelBuilder.Entity<Food>().HasData(


               //Srishant   - swap out foodID,Name & the IMG reference for your foods img reference. 
               new { FoodID = "egg", Name = "Omelette - Sunny-Side-Up", GenreID = "brk", MemberID = "bur", LogoImage = "omel.png" },
               new { FoodID = "steak", Name = "Well-Done Steak", GenreID = "lun", MemberID = "bur", LogoImage = "steak.png" },
               new { FoodID = "biryani", Name = "Chicken Biryani", GenreID = "din", MemberID = "bur", LogoImage = "biryani.png" },
               new { FoodID = "sandwich", Name = "Sandwiches", GenreID = "snk", MemberID = "bur", LogoImage = "sandwich.png" },

               //Robert - swap out foodID,Name & the IMG reference for your foods img reference. 
               new { FoodID = "westernOmelette", Name = "Western Omelette", GenreID = "brk", MemberID = "har", LogoImage = "longest_yard.png" },
               new { FoodID = "pirates", Name = "Pirates of the Caribbean", GenreID = "lun", MemberID = "har", LogoImage = "pirates_caribbean.png" },
               new { FoodID = "October", Name = "October Sky", GenreID = "din", MemberID = "har", LogoImage = "october_sky.png" },
               new { FoodID = "princess", Name = "Princess Bride", GenreID = "snk", MemberID = "har", LogoImage = "princess_bride.png" },

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
