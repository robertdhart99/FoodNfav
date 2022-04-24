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
                new Member { MemberID = "che", Name = "Zilong Chen", Major = "Information Techology - Software Development", Year = "Junior", Bio = "Why don't you listen to dubstep?" },
                new Member { MemberID = "pok", Name = "Bhakti Pokhrel",Major = "Enter Major Here", Year = "Enter year Here", Bio = "Enter BIO HERE" },
                new Member { MemberID = "har", Name = "Robert Hart", Major = "Information Techology - Software Development || Cyber Security", Year = "Senior", Bio = "I prefer to go by Bobby. I will be graduating in august with my IT software dev and cybersecurity degrees. I love to sail and hope to one day Sail around the world." } 
                
            );
            modelBuilder.Entity<Food>().HasData(


               //Srishant   
               new { FoodID = "omel", Name = "Omelette", GenreID = "brk", MemberID = "bur", LogoImage = "omel.png" },
               new { FoodID = "stek", Name = "Well-Done Steak", GenreID = "lun", MemberID = "bur", LogoImage = "steak.png" },
               new { FoodID = "biry", Name = "Chicken Biryani", GenreID = "din", MemberID = "bur", LogoImage = "biryani.png" },
               new { FoodID = "sandwich", Name = "Sandwich", GenreID = "snk", MemberID = "bur", LogoImage = "sandwich.png" },

               //Robert - 
               new { FoodID = "westerno", Name = "Western Omelette", GenreID = "brk", MemberID = "har", LogoImage = "western_omelette.png" },
               new { FoodID = "frenchd", Name = "French Dip", GenreID = "lun", MemberID = "har", LogoImage = "french_dip.png" },
               new { FoodID = "gporkc", Name = "Glazed Pork Chops", GenreID = "din", MemberID = "har", LogoImage = "glazed_pork_chops.png" },
               new { FoodID = "tortc", Name = "Tortilla Chips", GenreID = "snk", MemberID = "har", LogoImage = "tortilla_chips.png" },

               //Zilong- 
               new { FoodID = "steamb", Name = "Steamed Stuffed Bun", GenreID = "brk", MemberID = "che", LogoImage = "steamed_bun.png" },
               new { FoodID = "fcarroty", Name = "Fried Carrot with Yam", GenreID = "lun", MemberID = "che", LogoImage = "fried_carrot_with_yam.png" },
               new { FoodID = "sweetnscarp", Name = "Sweat and Sour Carp", GenreID = "din", MemberID = "che", LogoImage = "sweat_and_sour_carp.png" },
               new { FoodID = "cooki", Name = "cookie", GenreID = "snk", MemberID = "che", LogoImage = "cookie.png" },

               //Bhakti   -  
               new { FoodID = "bec", Name = "Bacon Egg and Cheese sandwich", GenreID = "brk", MemberID = "pok", LogoImage = "egg_sandwich.png" },
               new { FoodID = "curry", Name = "Curry", GenreID = "lun", MemberID = "pok", LogoImage = "curry.png" }, 
               new { FoodID = "momo", Name = "Momo", GenreID = "din", MemberID = "pok", LogoImage = "momo.png" }, 
               new { FoodID = "chatepate", Name = "Chatepate", GenreID = "snk", MemberID = "pok", LogoImage = "chatepate.png" }

           );
        }
    }
}
