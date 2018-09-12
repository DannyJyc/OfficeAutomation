using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OfficeAutomation.Authorize
{
    public class AuthorizeController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //if (HttpContext.Session.GetString("user") == null)
            //{
            //    filterContext.Result = new RedirectResult("/User/IndexNull");

            //}
            //base.OnActionExecuting(filterContext);
        }
    }
}