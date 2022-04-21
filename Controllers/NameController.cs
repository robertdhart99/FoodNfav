
using Microsoft.AspNetCore.Mvc;
using Movies7.Models;

namespace Movies7.Controllers
{
    public class NameController : Controller
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
        public RedirectToActionResult Change(MovieListViewModel model)
        {
            var session = new Movies7Session(HttpContext.Session);            
            session.SetName(model.UserName);           
            return RedirectToAction("Index", "Home", new {
                    ActiveGenre = session.GetActiveGenre(),
                    ActiveMember = session.GetActiveMember()
                });
        }
    }
}