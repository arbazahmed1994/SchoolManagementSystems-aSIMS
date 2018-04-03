using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace aSIMS.Common
{
    public class ExtendIdAuthorizeAttribute : AuthorizeAttribute
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }

        public ExtendIdAuthorizeAttribute()
        {
            //RoleRepository roleRep = new RoleRepository();
            //Roles = roleRep.GetAuthorizedRoles(ControllerName, ActionName);
        }

        protected override void HandleUnauthorizedRequest(System.Web.Mvc.AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAuthenticated)
            {
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary {
                  { "action", "Unauthorized" },
                  { "controller", "Home" },
                  { "area", "" }
                  }
              );
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary {
                  { "action", "Login" },
                  { "controller", "Account" },
                  { "area", "" },
                  { "returnUrl", HttpContext.Current.Request.Url }
                  }
              );
            }
        }
    }
}