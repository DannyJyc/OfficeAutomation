using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.Authorize;
using OfficeAutomation.BLL;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.Controllers
{
    public class UsersController : AuthorizeController
    {
        private DAL.Helper.JsonUserConvert jsonUserConvert = new JsonUserConvert();

        private BLL.BLL_Users bllUsers = new BLL_Users();
        private BLL.BLL_College bllCollege = new BLL_College();
        private BLL.BLL_Effect bllEffect = new BLL_Effect();
        private BLL.BLL_Dictionary bllDictionary = new BLL_Dictionary();
        private DAL.DAL_User dalUser = new DAL_User();
        private DAL.DAL_College dalCollege = new DAL_College();
        private DAL.DAL_Dictionary dalDictionary = new DAL_Dictionary();
        private DAL.DAL_Effect dalEffect = new DAL_Effect();
      
       
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
            return Json(bllUsers.List(jsonUserConvert.StringToObject(HttpContext.Session.GetString("users")),page,limit));
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

        public JsonResult ListRole()
        {
            return Json(dalDictionary.List());
        }
        public IActionResult AddRole(int id = 0)
        {
            ViewData["id"] = id;
            
            if (id > 0)
            {
                ViewData["value"] = dalDictionary.Single(id);
                return View(dalEffect.List());
            }
            return View(dalEffect.List());
        }

        public JsonResult UpdateRole(related related)
        {
            return Json(bllDictionary.Update(related));
        }
        public JsonResult GetRole(int page,int limit)
        {
            return Json(bllDictionary.List(page,limit));
        }
        [HttpPost]
        public JsonResult DelRole(int id)
        {
            return Json(bllDictionary.Del(id));
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

        public JsonResult GetAllEffect(int page,int limit)
        {
            return Json(bllEffect.List(page,limit));
        }
        public IActionResult AddEffect(int id = 0)
        {
            ViewData["id"] = id;
            if (id > 0)
            {
                return View(dalEffect.Single(id));
            }
            return View();
        }

        public JsonResult UpdateEffect(effect effect)
        {
            return Json(bllEffect.Update(effect));
        }
        [HttpPost]
        public JsonResult DelEffect(int id)
        {
            return Json(bllEffect.Del(id));
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

        public JsonResult UpdateCollege(college college)
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