using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeAutomation.DAL;

namespace OfficeAutomation.Controllers
{
    public class DictionaryController : Controller
    {
        private  DAL.DAL_bu_dictionary dalBuDictionary = new DAL_bu_dictionary();

        public JsonResult Get()
        {
            return Json(dalBuDictionary.List());
        }
    }
}