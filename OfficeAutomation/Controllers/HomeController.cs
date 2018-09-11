using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OfficeAutomation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("users");
            return View();
        }

        public IActionResult Console()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Theme()
        {
            return View();
        }
    }
}