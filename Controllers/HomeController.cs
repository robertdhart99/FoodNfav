
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodFavorites.Models;

namespace FoodFavorites.Controllers
{
    public class HomeController : Controller
    {
        private FoodContext context;

        public HomeController(FoodContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(string activeGenre = "all", string activeMember = "all")
        {
            var session = new FoodFavoritesSession(HttpContext.Session);
            session.SetActiveGenre(activeGenre);
            session.SetActiveMember(activeMember);

            // if no count value in session, use data in cookie to restore fave teams in session 
            int? count = session.GetMyFoodCount();
            if (count == null) {
                var cookies = new FoodFavoritesCookies(HttpContext.Request.Cookies);
                string[] ids = cookies.GetMyFoodsIds();

                List<Food> myfoods = new List<Food>(); 
                if (ids.Length > 0)
                    myfoods = context.Foods.Include(t => t.Genre)
                        .Include(t => t.Member)
                        .Where(t => ids.Contains(t.FoodID)).ToList();
                session.SetMyFoods(myfoods);
            }

            var model = new FoodListViewModel
            {
                ActiveGenre = activeGenre,
                ActiveMember = activeMember,
                Genres = context.Genres.ToList(),
                Members = context.Members.ToList()
            };

            IQueryable<Food> query = context.Foods;
            if (activeGenre != "all")
                query = query.Where(
                    t => t.Genre.GenreID.ToLower() == activeGenre.ToLower());
            if (activeMember != "all")
                query = query.Where(
                    t => t.Member.MemberID.ToLower() == activeMember.ToLower());
            model.Foods = query.ToList();

            return View(model);
        }

        public IActionResult Details(string id)
        {
            var session = new FoodFavoritesSession(HttpContext.Session);
            var model = new FoodViewModel
            {
                Food = context.Foods
                    .Include(t => t.Genre)
                    .Include(t => t.Member)
                    .FirstOrDefault(t => t.FoodID == id),
                ActiveMember = session.GetActiveMember(),
                ActiveGenre = session.GetActiveGenre()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(FoodViewModel model)
        {
            model.Food = context.Foods
                .Include(t => t.Genre)
                .Include(t => t.Member)
                .Where(t => t.FoodID == model.Food.FoodID)
                .FirstOrDefault();

            var session = new FoodFavoritesSession(HttpContext.Session);
            var foods = session.GetMyFoods();
            foods.Add(model.Food);
            session.SetMyFoods(foods);

            var cookies = new FoodFavoritesCookies(HttpContext.Response.Cookies);
            cookies.SetMyFoodsIds(foods);

            TempData["message"] = $"{model.Food.Name} added to your favorites";

            return RedirectToAction("Index",
                new {
                    ActiveGenre = session.GetActiveGenre(),
                    ActiveMember = session.GetActiveMember()
                });
        }
    }
}