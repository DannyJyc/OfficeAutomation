using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.BLL;
using OfficeAutomation.DAL;
using OfficeAutomation.Models;

namespace OfficeAutomation.Controllers
{
    public class CategoryController : Controller
    {
        private BLL.BLL_Onelevel bllOnelevel = new BLL_Onelevel();
        private DAL.DAL_Onelevel dalOnelevel = new DAL_Onelevel();
        private BLL.BLL_Twolevel bllTwolevel = new BLL_Twolevel();
        private DAL.DAL_Twolevel dalTwolevel = new DAL_Twolevel();
        private BLL.BLL_Threelevel bllThreelevel = new BLL_Threelevel();
        private DAL.DAL_Threelevel dalThreelevel = new DAL_Threelevel();

        public IActionResult Level()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetCascader()
        {
            var i = bllOnelevel.CascadersList();
            return Json(bllOnelevel.CascadersList());
        }

        public IActionResult One()
        {
            return View();
        }

        public JsonResult List(int page,int limit)
        {
            return Json(bllOnelevel.List(page, limit));
        }

        public JsonResult OList()
        {
            return Json(dalOnelevel.List());
        }
        public JsonResult Del(int id)
        {
            return Json(bllOnelevel.Del(id));
        }

        public IActionResult Addone(int id = 0)
        {
            ViewData["id"] = id;
            if (id > 0)
            {
                return View(dalOnelevel.Single(id));
            }
            return View();
        }
        [HttpPost]
        public JsonResult Addone(onelevel onelevel)
        {
            return Json(bllOnelevel.Update(onelevel));
        }

        public IActionResult Two()
        {
            return View();
        }
        public JsonResult TwoList(int page, int limit)
        {
            return Json(bllTwolevel.List(page, limit));
        }

        public JsonResult Tlist()
        {
            return Json(dalTwolevel.List());
        }
        public JsonResult TwoDel(int id)
        {
            return Json(bllTwolevel.Del(id));
        }

        public IActionResult Addtwo(int id = 0)
        {
            ViewData["id"] = id;
            if (id > 0)
            {
                return View(dalTwolevel.Single(id));
            }
            return View();
        }
        [HttpPost]
        public JsonResult Addtwo(twolevel twolevel)
        {
            return Json(bllTwolevel.Update(twolevel));
        }
        public IActionResult Three()
        {
            return View();
        }
        public JsonResult ThreeList(int page, int limit)
        {
            return Json(bllThreelevel.List(page, limit));
        }

        public JsonResult ThreeDel(int id)
        {
            return Json(bllThreelevel.Del(id));
        }

        public IActionResult Addthree(int id = 0)
        {
            ViewData["id"] = id;
            if (id > 0)
            {
                return View(dalThreelevel.Single(id));
            }
            return View();
        }
        [HttpPost]
        public JsonResult Addthree(threelevel threelevel)
        {
            return Json(bllThreelevel.Update(threelevel));
        }
        [HttpPost]
        public JsonResult UpdateState(int id, int state)
        {
            return Json(bllThreelevel.UpdateState(id, state));
        }
    }
}