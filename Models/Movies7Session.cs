

using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Movies7.Models
{
    public class Movies7Session
    {
        private const string MoviesKey = "mymovies";
        private const string CountKey = "moviecount";
        private const string GenreKey = "genre";
        private const string MemberKey = "member";
        private const string NameKey = "name";

        private ISession session { get; set; }
        public Movies7Session(ISession session) {
            this.session = session;
        }

        public void SetMyMovies(List<Movie> movies) {
            session.SetObject(MoviesKey, movies);
            session.SetInt32(CountKey, movies.Count);
        }
        public List<Movie> GetMyMovies() =>
            session.GetObject<List<Movie>>(MoviesKey) ?? new List<Movie>();
        public int? GetMyMovieCount() => session.GetInt32(CountKey);

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

        public void RemoveMyMovies() {
            session.Remove(MoviesKey);
            session.Remove(CountKey);
        }
    }
}


