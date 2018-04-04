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
    public class StudentController : Controller
    {
        private StudentRepository _rep = new StudentRepository();

        public ActionResult Index()
        {
            @ViewBag.Main = "List";
            @ViewBag.Sub = "Student";
            IEnumerable<StudentModel> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Student";
            StudentModel model = new StudentModel();
            model.FillData();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(StudentModel model)
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Student";

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        model.EntryUser = (int)Session["UserID"];
            //        _rep.Create(model);
            //        model = new StudentModel();
            //        ModelState.Clear();
            //        TempData["Message"] = "success";
            //        TempData["SuccessMessage"] = MessageNaming.SuccessDataEntry;
            //    }
            //    catch (Exception ex)
            //    {
            //        TempData["Message"] = "error";
            //        TempData["ErrorMessage"] = ex.Message;
            //    }
            //}
            model.FillData();
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            @ViewBag.Main = "Updation";
            @ViewBag.Sub = "Student";

            StudentModel model = new StudentModel();
            model.FillData();
            model = _rep.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(StudentModel model)
        {
            @ViewBag.Main = "Updation";
            @ViewBag.Sub = "Student";

            if (ModelState.IsValid)
            {
                try
                {
                    model.EntryUser = (int)Session["UserID"];
                    _rep.Edit(model);
                    model = new StudentModel();
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
            model.FillData();
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            _rep.DeleteTwoSPName = "DeleteStudent";
            try
            {
                if (_rep.DeleteTwo(id, (int)Session["UserID"]) == 1)
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
            catch (Exception ex)
            {
                TempData["Message"] = "error";
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }

        }

    }
}
