using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using OfficeAutomation.DAL;
using OfficeAutomation.DAL.Helper;
using OfficeAutomation.Models;

namespace OfficeAutomation.Authorize
{
    public class Author : ActionFilterAttribute
    {
        private DAL.DAL_User dalUser = new DAL_User();
        public bool IsCheck { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (IsCheck)
            {
                var users = filterContext.HttpContext.Session.GetString("users");
                DAL.Helper.JsonUserConvert jsonUserConvert = new JsonUserConvert();
                if (users == null || users == "")
                {
                    filterContext.Result = new RedirectResult("/Login", false);
                    return;
                }
                else
                {
                    users ObjUser = jsonUserConvert.StringToObject(users);
                    if (ObjUser.dicvalue != "0")
                    {
                        string result = filterContext.ActionDescriptor.DisplayName;
                        string[] array = result.Split('.');
                        string controller = array[3];
                        if (ObjUser.dicvalue == "1")
                        {
                            switch (controller)
                            {
                                case "UsersController":
                                case "HomeController":
                                case "BasedataController":
                                    return;
                                default:
                                    break;
                            }
                        }

                        if (!dalUser.IsHaveEffect(ObjUser.id, controller))
                        {
                            if (!dalUser.IsHaveControl(ObjUser.id))
                            {
                                filterContext.Result = new RedirectResult("/Login/Insufficient", false);
                                return;
                            }
                            filterContext.Result = new RedirectResult("/Login/Insufficient", false);
                            return;
                        }
                    }
                }
            }
        }
    }
}
