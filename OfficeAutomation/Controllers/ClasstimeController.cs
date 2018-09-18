using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.BLL;
using OfficeAutomation.DAL;

namespace OfficeAutomation.Controllers
{
    public class ClasstimeController : Controller
    {
        private BLL.BLL_Classtime_All bllClasstimeAll = new BLL_Classtime_All();
        private DAL.DAL_Classtime_All dalClasstimeAll = new DAL_Classtime_All();
        private DAL.DAL_College dalCollege = new DAL_College();
        public IActionResult Index()
        {
            return View(dalCollege.List());
        }

        public IActionResult ByTeacher()
        {
            return View();
        }
        public JsonResult Get(int collegeid, int classesid, int week)
        {
            return Json(bllClasstimeAll.GetAllClasstime(collegeid,classesid,week));
        }

        public JsonResult GetClassesByCollege(int collegeid)
        {
            var i = dalClasstimeAll.ListDesignatedClass(collegeid);
            return Json(dalClasstimeAll.ListDesignatedClass(collegeid));
        }
    }
}