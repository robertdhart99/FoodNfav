namespace Movies7.Models
{
    public class Movie
    {
        public string MovieID { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public Member Member { get; set; }
        public string LogoImage { get; set; }
    }
}
