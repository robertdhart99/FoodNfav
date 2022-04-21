
using Microsoft.AspNetCore.Mvc;

using Movies7.Models;

namespace Movies7.Controllers
{
    public class FavoritesController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new Movies7Session(HttpContext.Session);
            var model = new MovieListViewModel
            {
                ActiveGenre = session.GetActiveGenre(),
                ActiveMember = session.GetActiveMember(),
                Movies = session.GetMyMovies(),
                UserName = session.GetName()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new Movies7Session(HttpContext.Session);
            var cookies = new Movies7Cookies(HttpContext.Response.Cookies);

            session.RemoveMyMovies();
            cookies.RemoveMyMovieIds();

            TempData["message"] = "Favorite movies cleared";

            return RedirectToAction("Index", "Home",
                new {
                    ActiveGenre = session.GetActiveGenre(),
                    ActiveMember = session.GetActiveMember()
                });
        }
    }
}  