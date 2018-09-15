using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.BLL;
using OfficeAutomation.DAL;
using OfficeAutomation.Models;

namespace OfficeAutomation.Controllers
{
    public class BasedataController : Controller
    {
        private BLL.BLL_Classes bllClasses = new BLL_Classes();
        private BLL.BLL_Teachers bllTeachers = new BLL_Teachers();
        private BLL.BLL_Courses bllCourses = new BLL_Courses();
        private DAL.DAL_Classes dalcaClasses = new DAL_Classes();
        private DAL.DAL_Teachers dalTeachers = new DAL_Teachers();
        private DAL.DAL_Courses dalCourses = new DAL_Courses();
        private DAL.DAL_College dalCollege = new DAL_College();
        /// <summary>
        /// 专业
        /// </summary>
        /// <returns></returns>
        public IActionResult Classes()
        {
            return View();
        }
        public JsonResult AllClasses(int id=0)
        {
            return Json(dalcaClasses.List());
        }
        public JsonResult GetAllClasses(int page, int limit)
        {
            return Json(bllClasses.List(page, limit));
        }
        public IActionResult AddClasses(int id = 0)
        {
            ViewData["id"] = id;
            if (id > 0)
            {
                return View(dalcaClasses.Single(id));
            }
            return View();
        }

        public JsonResult UpdateClasses(classes classes)
        {
            return Json(bllClasses.Update(classes));
        }
        [HttpPost]
        public JsonResult DelClasses(int id)
        {
            return Json(bllClasses.Del(id));
        }
        ///*******************************************************************************************************
        ///*******************************************************************************************************

        /// <summary>
        /// 教师
        /// </summary>
        /// <returns></returns>
        public IActionResult Teachers()
        {
            return View();
        }

        public JsonResult GetTeachers()
        {
            return Json(dalTeachers.List());
        }
        public JsonResult GetAllTeachers(int page, int limit)
        {
            return Json(bllTeachers.List(page, limit));
        }
        public IActionResult AddTeachers(int id = 0)
        {
            ViewData["id"] = id;
            if (id > 0)
            {
                return View(dalTeachers.Single(id));
            }
            return View();
        }

        public JsonResult UpdateTeachers(teachers teachers)
        {
            return Json(bllTeachers.Update(teachers));
        }
        [HttpPost]
        public JsonResult DelTeachers(int id)
        {
            return Json(bllTeachers.Del(id));
        }
        ///*******************************************************************************************************
        ///*******************************************************************************************************
        /// <summary>
        /// 课程
        /// </summary>
        /// <returns></returns>
        public IActionResult Courses()
        {
            return View();
        }
        public JsonResult AllCourses(int id=0)
        {
            if (id != 0)
            {
                var i = dalCourses.List(id);
                return Json(dalCourses.List(id));
            }
            return Json(dalCourses.List());
        }
        public JsonResult GetAllCourses(int page, int limit)
        {
            return Json(bllCourses.List(page, limit));
        }
        public IActionResult AddCourses(int id = 0)
        {
            ViewData["id"] = id;
            if (id > 0)
            {
                return View(dalCourses.Single(id));
            }
            return View();
        }

        public JsonResult UpdateCourses(courses courses)
        {
            return Json(bllCourses.Update(courses));
        }
        [HttpPost]
        public JsonResult DelCourses(int id)
        {
            return Json(bllCourses.Del(id));
        }
        ///*******************************************************************************************************
        ///*******************************************************************************************************
        /// <summary>
        /// 课表
        /// </summary>
        /// <returns></returns>
        public IActionResult Classtime()
        {
            return View();
        }

        public IActionResult AddClasstime(int id = 0)
        {
            ViewData["id"] = id;
            if (id > 0)
            {
                return View(dalCourses.Single(id));
            }
            return View();
        }
    }
}