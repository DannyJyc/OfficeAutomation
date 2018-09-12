using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OfficeAutomation.Authorize
{
    public class Author : ActionFilterAttribute
    {
        public bool IsCheck { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (IsCheck)
            {
                if (filterContext.HttpContext.Session.GetString("users") == null ||
                    filterContext.HttpContext.Session.GetString("users") == "")
                {
                    filterContext.Result = new RedirectResult("/Login", false);
                    return;
                }
            }
        }
    }
}
