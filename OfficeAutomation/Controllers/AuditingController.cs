using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.BLL;

namespace OfficeAutomation.Controllers
{
    public class AuditingController : Controller
    {
        private BLL.BLL_Auditing bllAuditing = new BLL_Auditing();
        /// <summary>
        /// 审核运营项目
        /// </summary>
        /// <returns></returns>
        public IActionResult ItemAuditing()
        {
            return View();
        }
        /// <summary>
        /// 获取运营项目审核数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public JsonResult GetItem(int page,int limit)
        {
            return Json(bllAuditing.List(page, limit));
        }
    }
}