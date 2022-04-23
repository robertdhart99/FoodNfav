
using System;
using System.Collections.Generic;

namespace FoodFavorites.Models
{
    public class FoodListViewModel : FoodViewModel
    {
        public String UserName { get; set; }
        public List<Food> Foods { get; set; }

        // use full properties for Conferences and Divisions 
        // so can add 'All' item at beginning
        private List<Genre> genres;
        public List<Genre> Genres {
            get => genres; 
            set {
                genres = new List<Genre> {
                    new Genre { GenreID = "all", Name = "All" }
                };
                Genres.AddRange(value);
            }
        }

        private List<Member> members;
        public List<Member> Members {
            get => members; 
            set {
                members = new List<Member> {
                    new Member { MemberID = "all", Name = "All" }
                };
               members.AddRange(value);
            }
        }

        // methods to help view determine active link
        public string CheckActiveGenre(string c) => 
            c.ToLower() == ActiveGenre.ToLower() ? "active" : "";
        public string CheckActiveMember(string d) => 
            d.ToLower() == ActiveMember.ToLower() ? "active" : "";

    }
}


