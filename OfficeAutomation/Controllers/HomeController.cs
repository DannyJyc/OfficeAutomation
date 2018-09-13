using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.Authorize;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.Controllers
{
    [Author(IsCheck = true)]
    public class HomeController : AuthorizeController
    {
        private DAL.Helper.JsonUserConvert JsonConvert = new JsonUserConvert();
        public IActionResult Index()
        {
            string user = HttpContext.Session.GetString("users");
            users userobj = JsonConvert.StringToObject(user);
            ViewData["username"] = userobj.name;
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