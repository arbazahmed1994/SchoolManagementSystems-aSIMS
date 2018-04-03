using aSIMS.Common;
using aSIMS.Constants;
using aSIMS.Repository;
using aSIMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aSIMS.Controllers
{
    
    public class HomeController : Controller
    {

        private HomeRepository _rep = new HomeRepository();

        public ActionResult Login()
        {
            TempData["LoginError"] = null;
            return View(new CredentialsViewModel());
        }
        [HttpPost]
        public ActionResult Login(CredentialsViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    UserInfoViewModel UserModel = _rep.LoginUser(model);
                    BasicContants.RoleID = UserModel.RoleID;
                    Session["UserID"] = UserModel.UserID;
                    Session["FullName"] = UserModel.FullName;
                    Session["Designation"] = UserModel.Designation;
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    TempData["LoginError"] = ex.Message;
                    return View();
                }
                
            }
            else
            {
                return View();
            }
        }

        [SessionTimeout]
        public ActionResult Index()
        {
            return View();
        }

        [SessionTimeout]
        public ActionResult Unauthorized()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Home");
        }

    }
}
