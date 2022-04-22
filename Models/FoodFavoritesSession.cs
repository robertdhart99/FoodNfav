

using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace FoodFavorites.Models
{
    public class FoodFavoritesSession
    {
        private const string FoodsKey = "myfoods";
        private const string CountKey = "foodcount";
        private const string GenreKey = "genre";
        private const string MemberKey = "member";
        private const string NameKey = "name";

        private ISession session { get; set; }
        public FoodFavoritesSession(ISession session) {
            this.session = session;
        }

        public void SetMyFoods(List<Food> foods) {
            session.SetObject(FoodsKey, foods);
            session.SetInt32(CountKey, foods.Count);
        }
        public List<Food> GetMyFoods() =>
            session.GetObject<List<Food>>(FoodsKey) ?? new List<Food>();
        public int? GetMyFoodCount() => session.GetInt32(CountKey);

        public void SetName(string userName = "friend")
        {
            session.SetString(NameKey, userName);
        }
        public string GetName() => session.GetString(NameKey);
        
        public void SetActiveGenre(string genre) =>
            session.SetString(GenreKey, genre);
        public string GetActiveGenre() => session.GetString(GenreKey);

        public void SetActiveMember(string member) =>
            session.SetString(MemberKey, member);
        public string GetActiveMember() => session.GetString(MemberKey);

        public void RemoveMyFoods() {
            session.Remove(FoodsKey);
            session.Remove(CountKey);
        }
    }
}


