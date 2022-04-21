using Microsoft.EntityFrameworkCore;

namespace Movies7.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreID = "com", Name = "Comedy"},
                new Genre { GenreID = "hor", Name = "Horror" }, 
                new Genre { GenreID = "act", Name = "Action" }, 
                new Genre { GenreID = "dra", Name = "Drama" }
            );
            modelBuilder.Entity<Member>().HasData(
                new Member { MemberID = "bea", Name = "Chevaux Beasley", Major = "Information Techology", Year = "Senior", Bio = "I like cars, watching anime and playing video games" },
                new Member { MemberID = "bro", Name = "Chris Brown", Major = "Information Techology - Software Development", Year = "Junior", Bio = "I'm a nerd." },
                new Member { MemberID = "dan", Name = "Ibukun Daniel",Major = "Information Techology - Software Development || CS minor", Year = "Junior", Bio = "I am groot"},
                new Member { MemberID = "har", Name = "Robert Hart", Major = "Information Techology - Software Development || Cyber Security", Year = "Senior", Bio = "I go by Bobby. I am about to finish my IT software dev and cybersecurity degrees. I love spending time outdoors but also like playing games." }, 
                new Member { MemberID = "emi", Name = "Emily Hempker", Major = "Information Techology - Software Development", Year = "Junior", Bio = "I'm a weeb and a furry." }
            );
            modelBuilder.Entity<Movie>().HasData(
               new { MovieID = "shrek", Name = "Shrek", GenreID = "com", MemberID = "emi", LogoImage = "shrek.png" },
               new { MovieID = "shrek2", Name = "Shrek 2", GenreID = "com", MemberID = "emi", LogoImage = "shrek_2.png" },
               new { MovieID = "shrek3", Name = "Shrek 3", GenreID = "com", MemberID = "emi", LogoImage = "shrek_3.png" },
               new { MovieID = "shrek4", Name = "Shrek 4", GenreID = "com", MemberID = "emi", LogoImage = "shrek_4.png" },
               new { MovieID = "silent", Name = "Silent Hill", GenreID = "hor", MemberID = "emi", LogoImage = "silent_hill.png" },
               new { MovieID = "long", Name = "Longest Yard", GenreID = "com", MemberID = "har", LogoImage = "longest_yard.png" },
               new { MovieID = "pirates", Name = "Pirates of the Caribbean", GenreID = "act", MemberID = "har", LogoImage = "pirates_caribbean.png" },
               new { MovieID = "October", Name = "October Sky", GenreID = "dra", MemberID = "har", LogoImage = "october_sky.png" },
               new { MovieID = "princess", Name = "Princess Bride", GenreID = "dra", MemberID = "har", LogoImage = "princess_bride.png" },
               new { MovieID = "castle", Name = "Castle Cagliostro", GenreID = "act", MemberID = "bro", LogoImage = "castle_cagliostro.png" },
               new { MovieID = "fail", Name = "Fail Safe", GenreID = "hor", MemberID = "bro", LogoImage = "fail_safe_64.png" },
               new { MovieID = "saving", Name = "Saving Private Ryan", GenreID = "act", MemberID = "bro", LogoImage = "saving_private_ryan.png" },
               new { MovieID = "arsenic", Name = "Arsenic and Old Lace", GenreID = "hor", MemberID = "bro", LogoImage = "arsenic_old_lace.png" },
               new { MovieID = "santa", Name = "The Santa Clause", GenreID = "com", MemberID = "bro", LogoImage = "santa_clause.png" },
               new { MovieID = "fast", Name = "2 Fast 2 Furious", GenreID = "act", MemberID = "bea", LogoImage = "2_fast_2_furious.png" },
               new { MovieID = "nemo", Name = "Finding Nemo", GenreID = "com", MemberID = "bea", LogoImage = "finding_nemo.png" }, 
               new { MovieID = "black", Name = "Black Panther", GenreID = "act", MemberID = "bea", LogoImage = "black_panther.png" }, 
               new { MovieID = "blonde", Name = "Legally Blonde", GenreID = "com", MemberID = "bea", LogoImage = "legally_blonde.png" },
               new { MovieID = "dragon", Name = "Dragon Ball Super", GenreID = "act", MemberID = "bea", LogoImage = "db_super_broly.png" },
               new { MovieID = "rn", Name = "Red Notice", GenreID = "act", MemberID = "dan", LogoImage = "red_notice.png" },
               new { MovieID = "hog", Name = "House of Gucci", GenreID = "dra", MemberID = "dan", LogoImage = "house_gucci.png" },
               new { MovieID = "ttb", Name = "Train to Busan", GenreID ="dra", MemberID = "dan", LogoImage = "train_to_busan.png" },
               new { MovieID = "par", Name = "Parasite", GenreID = "hor", MemberID = "dan", LogoImage = "parasite.png" },
               new { MovieID = "free", Name = "Free Guy", GenreID = "com", MemberID = "dan", LogoImage = "free_guy.png" } 





           );
        }
    }
}
