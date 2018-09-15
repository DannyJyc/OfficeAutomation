using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OfficeAutomation.Controllers
{
    public class LookdataController : Controller
    {
        /// <summary>
        /// 查看数据
        /// </summary>
        /// <returns></returns>
        public IActionResult Lookdata()
        {
            return View();
        }
        /// <summary>
        /// 课表
        /// </summary>
        /// <returns></returns>
        public IActionResult Classtime()
        {
            return View();
        }
    }
}