using log4net.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeAutomation.BLL;
using OfficeAutomation.DAL.Helper;

namespace OfficeAutomation.Controllers
{
    public class LoginController : Controller
    {
        private BLL.BLL_Users bllUsers = new BLL_Users();
        /// <summary>
        /// 返回登录页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("users", "");
            return View();
        }
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public JsonResult Validate(string username,string password)
        {
            var user = bllUsers.Validate(username, password);
            if (user.code == 0)
            {
                HttpContext.Session.SetString("users", JsonConvert.SerializeObject(user.data));
            }
            var userget = HttpContext.Session.GetString("users");
            return Json(user);
        }
    }
}