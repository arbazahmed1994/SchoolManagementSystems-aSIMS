using aSIMS.Common;
using aSIMS.Models;
using aSIMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aSIMS.Controllers
{
    [SessionTimeout]
    public class EmployeeAccountController : Controller
    {

        private EmployeeAccountRepository _rep = new EmployeeAccountRepository();

        public ActionResult Index()
        {
            @ViewBag.Main = "List";
            @ViewBag.Sub = "Employee Accounts";
            IEnumerable<EmployeeAccountModel> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Employee Accounts";
            return View(new EmployeeAccountModel());
        }
        [HttpPost]
        public ActionResult Create(EmployeeAccountModel model)
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Employee Accounts";

            if (ModelState.IsValid)
            {
                try
                {
                    model.EntryUser = (int)Session["UserID"];
                    _rep.Create(model);
                    model = new EmployeeAccountModel();
                    ModelState.Clear();
                    TempData["Message"] = "success";
                    TempData["SuccessMessage"] = MessageNaming.SuccessDataEntry;
                }
                catch (Exception ex)
                {
                    TempData["Message"] = "error";
                    TempData["ErrorMessage"] = ex.Message;
                }
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            @ViewBag.Main = "Updation";
            @ViewBag.Sub = "Employee Accounts";
            EmployeeAccountModel model = new EmployeeAccountModel();
            model = _rep.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeAccountModel model)
        {
            @ViewBag.Main = "Updation";
            @ViewBag.Sub = "Employee Accounts";

            if (ModelState.IsValid)
            {
                try
                {
                    model.EntryUser = (int)Session["UserID"];
                    _rep.Edit(model);
                    model = new EmployeeAccountModel();
                    ModelState.Clear();
                    TempData["Message"] = "success";
                    TempData["SuccessMessage"] = MessageNaming.SuccessDataUpdate;
                }
                catch (Exception ex)
                {
                    TempData["Message"] = "error";
                    TempData["ErrorMessage"] = ex.Message;
                }
            }
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            if (_rep.Delete(id) == 1)
            {
                TempData["Message"] = "success";
                TempData["SuccessMessage"] = MessageNaming.SuccessDataDelete;
            }
            else
            {
                TempData["Message"] = "error";
                TempData["ErrorMessage"] = MessageNaming.ErrorDataDelete;
            }
            return RedirectToAction("Index");
        }

    }
}
