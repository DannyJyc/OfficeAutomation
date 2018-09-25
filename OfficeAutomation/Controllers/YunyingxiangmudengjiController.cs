using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.BLL;
using OfficeAutomation.Models;

namespace OfficeAutomation.Controllers
{
    public class YunyingxiangmudengjiController : Controller
    {
        private BLL.BLL_yunyingxiangmuguanli bllYunyingxiangmuguanli = new BLL_yunyingxiangmuguanli();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Add(yunyingxiangmudengji yunyingxiangmudengji)
        {
            return Json(bllYunyingxiangmuguanli.Add(yunyingxiangmudengji));
        }
    }
}