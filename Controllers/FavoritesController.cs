
using Microsoft.AspNetCore.Mvc;

using FoodFavorites.Models;

namespace FoodFavorites.Controllers
{
    public class FavoritesController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            var session = new FoodFavoritesSession(HttpContext.Session);
            var model = new FoodListViewModel
            {
                ActiveGenre = session.GetActiveGenre(),
                ActiveMember = session.GetActiveMember(),
                Foods = session.GetMyFoods(),
                UserName = session.GetName()
            };

            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new FoodFavoritesSession(HttpContext.Session);
            var cookies = new FoodFavoritesCookies(HttpContext.Response.Cookies);

            session.RemoveMyFoods();
            cookies.RemoveMyFoodsIds();

            TempData["message"] = "Favorite Foods cleared";

            return RedirectToAction("Index", "Home",
                new {
                    ActiveGenre = session.GetActiveGenre(),
                    ActiveMember = session.GetActiveMember()
                });
        }
    }
}  