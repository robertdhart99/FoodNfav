
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace Movies7.Models
{
    public class Movies7Cookies
    {
        private const string MoviesKey = "mymovies";
        private const string Delimiter = "-";

        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }
        public Movies7Cookies(IRequestCookieCollection cookies) {
            requestCookies = cookies;
        }
        public Movies7Cookies(IResponseCookies cookies) {
            responseCookies = cookies;
        }

        public void SetMyMoviesIds(List<Movie> mymovies)
        {
            List<string> ids = mymovies.Select(t => t.MovieID).ToList();
            string idsString = String.Join(Delimiter, ids);
            CookieOptions options = new CookieOptions { Expires = DateTime.Now.AddDays(30) };
            RemoveMyMovieIds();     // delete old cookie first
            responseCookies.Append(MoviesKey, idsString, options);
        }

        public string[] GetMyMovieIds()
        {
            string cookie = requestCookies[MoviesKey];
            if (string.IsNullOrEmpty(cookie))
                return new string[] { };   // empty string array
            else
                return cookie.Split(Delimiter);
        }      

        public void RemoveMyMovieIds()
        {
            responseCookies.Delete(MoviesKey);
        }
    }
}


