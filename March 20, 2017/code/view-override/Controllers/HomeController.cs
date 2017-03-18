using Microsoft.AspNetCore.Mvc;

namespace view_override.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Index";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Name = "About";
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Name = "Contact";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public override ViewResult View() {
            ViewBag.Message = "A Shared Message";
            return base.View();
        }
    }
}
