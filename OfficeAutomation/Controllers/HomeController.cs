using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.Authorize;

namespace OfficeAutomation.Controllers
{
    [Author(IsCheck = true)]
    public class HomeController : AuthorizeController
    {
        public IActionResult Index()
        {
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