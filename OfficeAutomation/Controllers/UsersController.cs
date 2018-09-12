using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.BLL;
using OfficeAutomation.DAL;
using OfficeAutomation.Models;

namespace OfficeAutomation.Controllers
{
    public class UsersController : Controller
    {
        private BLL.BLL_Users bllUsers = new BLL_Users();
        private BLL.BLL_College bllCollege = new BLL_College();
        private DAL.DAL_User dalUser = new DAL_User();
        private DAL.DAL_College dalCollege = new DAL_College();
        private DAL.DAL_Dictionary dalDictionary = new DAL_Dictionary();
       
        /// <summary>
        /// 用户管理
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddIndex(int id = 0)
        {
            ViewData["id"] = id;
            if (id > 0)
            {
                return View(dalUser.SingleUsers(id));
            }
            return View();
        }

        public JsonResult GetUser(int page, int limit)
        {
            return Json(bllUsers.List(page,limit));
        }
        public JsonResult AddUser(users users)
        {
            return Json(bllUsers.AddUser(users));
        }
        [HttpPost]
        public JsonResult Del(int id)
        {
            return Json(bllUsers.DelUser(id));
        }
        public JsonResult EditState(int id, int type)
        {
            return Json(bllUsers.EditState(id,type));
        }
        ///*******************************************************************************************************
        ///*******************************************************************************************************
        /// <summary>
        /// 角色管理
        /// </summary>
        /// <returns></returns>
        public IActionResult Role()
        {
            return View();
        }

        public IActionResult AddRole()
        {
            return View();
        }

        public JsonResult GetRole()
        {
            return Json(dalDictionary.List());
        }
        ///*******************************************************************************************************
        ///*******************************************************************************************************
        /// <summary>
        /// 功能设置
        /// </summary>
        /// <returns></returns>
        public IActionResult Effect()
        {
            return View();
        }

        public IActionResult AddEffect()
        {
            return View();
        }
        ///*******************************************************************************************************
        ///*******************************************************************************************************
        /// <summary>
        /// 返回学院管理
        /// </summary>
        /// <returns></returns>
        public IActionResult College()
        {
            return View();
        }

        public IActionResult AddCollege(int id = 0)
        {
            ViewData["id"] = id;
            if (id > 0)
            {
                return View(dalCollege.Single(id));
            }
            return View();
        }

        public JsonResult AddCollege(college college)
        {
            return Json(bllCollege.UpdateCollege(college));
        }

        public JsonResult DelCollege(int id)
        {
            return Json(bllCollege.DelUser(id));
        }

        public JsonResult GetCollege()
        {
            return Json(dalCollege.List());
        }

        public JsonResult GetAllCollege(int page, int limit)
        {
            return Json(bllCollege.List(page,limit));
        }
    }
}