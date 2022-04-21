
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies7.Models;

namespace Movies7.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context;

        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(string activeGenre = "all", string activeMember = "all")
        {
            var session = new Movies7Session(HttpContext.Session);
            session.SetActiveGenre(activeGenre);
            session.SetActiveMember(activeMember);

            // if no count value in session, use data in cookie to restore fave teams in session 
            int? count = session.GetMyMovieCount();
            if (count == null) {
                var cookies = new Movies7Cookies(HttpContext.Request.Cookies);
                string[] ids = cookies.GetMyMovieIds();

                List<Movie> mymovies = new List<Movie>(); 
                if (ids.Length > 0)
                    mymovies = context.Movies.Include(t => t.Genre)
                        .Include(t => t.Member)
                        .Where(t => ids.Contains(t.MovieID)).ToList();
                session.SetMyMovies(mymovies);
            }

            var model = new MovieListViewModel
            {
                ActiveGenre = activeGenre,
                ActiveMember = activeMember,
                Genres = context.Genres.ToList(),
                Members = context.Members.ToList()
            };

            IQueryable<Movie> query = context.Movies;
            if (activeGenre != "all")
                query = query.Where(
                    t => t.Genre.GenreID.ToLower() == activeGenre.ToLower());
            if (activeMember != "all")
                query = query.Where(
                    t => t.Member.MemberID.ToLower() == activeMember.ToLower());
            model.Movies = query.ToList();

            return View(model);
        }

        public IActionResult Details(string id)
        {
            var session = new Movies7Session(HttpContext.Session);
            var model = new MovieViewModel
            {
                Movie = context.Movies
                    .Include(t => t.Genre)
                    .Include(t => t.Member)
                    .FirstOrDefault(t => t.MovieID == id),
                ActiveMember = session.GetActiveMember(),
                ActiveGenre = session.GetActiveGenre()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(MovieViewModel model)
        {
            model.Movie = context.Movies
                .Include(t => t.Genre)
                .Include(t => t.Member)
                .Where(t => t.MovieID == model.Movie.MovieID)
                .FirstOrDefault();

            var session = new Movies7Session(HttpContext.Session);
            var movies = session.GetMyMovies();
            movies.Add(model.Movie);
            session.SetMyMovies(movies);

            var cookies = new Movies7Cookies(HttpContext.Response.Cookies);
            cookies.SetMyMoviesIds(movies);

            TempData["message"] = $"{model.Movie.Name} added to your favorites";

            return RedirectToAction("Index",
                new {
                    ActiveGenre = session.GetActiveGenre(),
                    ActiveMember = session.GetActiveMember()
                });
        }
    }
}