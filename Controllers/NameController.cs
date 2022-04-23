
using Microsoft.AspNetCore.Mvc;
using FoodFavorites.Models;

namespace FoodFavorites.Controllers
{
    public class NameController : Controller
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
        public RedirectToActionResult Change(FoodListViewModel model)
        {
            var session = new FoodFavoritesSession(HttpContext.Session);            
            session.SetName(model.UserName);           
            return RedirectToAction("Index", "Home", new {
                    ActiveGenre = session.GetActiveGenre(),
                    ActiveMember = session.GetActiveMember()
                });
        }
    }
}