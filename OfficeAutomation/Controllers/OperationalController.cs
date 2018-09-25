using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.BLL;
using OfficeAutomation.DAL;

namespace OfficeAutomation.Controllers
{
    public class OperationalController : Controller
    {

        private BLL.BLL_yunyingxiangmuguanli bllYunyingxiangmuguanli = new BLL_yunyingxiangmuguanli();
        private DAL.DAL_yunyingxiangmudengji dalyunxiDalYunyingxiangmudengji = new DAL_yunyingxiangmudengji();
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 返回数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public JsonResult Get(int page, int limit)
        {
            return Json(bllYunyingxiangmuguanli.List(page, limit));
        }

        public IActionResult Update(int id = 0)
        {
            if (id != 0)
            {
                return View(dalyunxiDalYunyingxiangmudengji.Single(id));
            }

            return View();
        }
    }
}