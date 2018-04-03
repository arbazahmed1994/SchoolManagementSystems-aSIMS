using aSIMS.Common;
using aSIMS.Constants;
using aSIMS.Models;
using aSIMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace aSIMS.Controllers
{
    [SessionTimeout]
    public class NavbarController : Controller
    {

        private NavbarRepository _rep = new NavbarRepository();

        public ActionResult Index()
        {
            return View();
        }

        //[ExtendedAuthorizeAttribute]
        public ActionResult TopNav()
        {
            //IEnumerable<NavbarItem> model = _rep.Get();
            var navBar = new Navbar();
            return PartialView("TopNav", navBar.NavbarTop());
        }

        public ActionResult TopMenu()
        {
            return PartialView("TopMenu");
        }

    }
}
