
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace FoodFavorites.Models
{
    public class FoodFavoritesCookies
    {
        private const string FoodsKey = "myfoods";
        private const string Delimiter = "-";

        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }
        public FoodFavoritesCookies(IRequestCookieCollection cookies) {
            requestCookies = cookies;
        }
        public FoodFavoritesCookies(IResponseCookies cookies) {
            responseCookies = cookies;
        }

        public void SetMyFoodsIds(List<Food> myfoods)
        {
            List<string> ids = myfoods.Select(t => t.FoodID).ToList();
            string idsString = String.Join(Delimiter, ids);
            CookieOptions options = new CookieOptions { Expires = DateTime.Now.AddDays(30) };
            RemoveMyFoodsIds();     // delete old cookie first
            responseCookies.Append(FoodsKey, idsString, options);
        }

        public string[] GetMyFoodsIds()
        {
            string cookie = requestCookies[FoodsKey];
            if (string.IsNullOrEmpty(cookie))
                return new string[] { };   // empty string array
            else
                return cookie.Split(Delimiter);
        }      

        public void RemoveMyFoodsIds()
        {
            responseCookies.Delete(FoodsKey);
        }
    }
}


