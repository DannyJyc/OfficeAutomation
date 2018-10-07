using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.Authorize;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.Controllers
{
    [Author(IsCheck = true)]
    public class HomeController : AuthorizeController
    {
        private JsonUserConvert JsonConvert = new JsonUserConvert();
        private DAL_bu_dictionary dalBuDictionary = new DAL_bu_dictionary();
        public IActionResult Index()
        {
            string user = HttpContext.Session.GetString("users");
            users userobj = JsonConvert.StringToObject(user);
            ViewData["username"] = userobj.name;
            return View(dalBuDictionary.List());
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