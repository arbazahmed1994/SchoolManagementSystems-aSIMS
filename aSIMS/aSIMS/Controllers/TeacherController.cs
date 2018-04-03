using aSIMS.Common;
using aSIMS.Constants;
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
    public class TeacherController : Controller
    {

        private TeacherRepository _rep = new TeacherRepository();

        public ActionResult Index()
        {
            @ViewBag.Main = "List";
            @ViewBag.Sub = "Teachers";
            BasicContants.StoredProcedure = "GetTeachers";
            IEnumerable<TeacherModel> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Teachers";
            return View(new TeacherModel());
        }
        [HttpPost]
        public ActionResult Create(TeacherModel model)
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Teachers";

            if (ModelState.IsValid)
            {
                try
                {
                    model.EntryUser = (int)Session["UserID"];
                    _rep.Create(model);
                    model = new TeacherModel();
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
            @ViewBag.Sub = "Teachers";

            TeacherModel model = new TeacherModel();
            model = _rep.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(TeacherModel model)
        {
            @ViewBag.Main = "Updation";
            @ViewBag.Sub = "Teachers";

            if (ModelState.IsValid)
            {
                try
                {
                    model.EntryUser = (int)Session["UserID"];
                    _rep.Edit(model);
                    model = new TeacherModel();
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
