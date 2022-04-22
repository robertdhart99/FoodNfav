namespace FoodFavorites.Models
{
    public class Food
    {
        public string FoodID { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public Member Member { get; set; }
        public string LogoImage { get; set; }
    }
}
