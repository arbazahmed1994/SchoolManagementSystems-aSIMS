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
    public class ParentController : Controller
    {

        private ParentRepository _rep = new ParentRepository();

        public ActionResult Index()
        {
            @ViewBag.Main = "List";
            @ViewBag.Sub = "Parents";
            IEnumerable<ParentModel> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Parents";
            return View(new ParentModel());
        }
        [HttpPost]
        public ActionResult Create(ParentModel model)
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Parents";

            if (ModelState.IsValid)
            {
                try
                {
                    model.EntryUser = (int)Session["UserID"];
                    _rep.Create(model);
                    model = new ParentModel();
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
            @ViewBag.Sub = "Parents";
            ParentModel model = new ParentModel();
            model = _rep.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ParentModel model)
        {
            @ViewBag.Main = "Updation";
            @ViewBag.Sub = "Parents";

            if (ModelState.IsValid)
            {
                try
                {
                    model.EntryUser = (int)Session["UserID"];
                    _rep.Edit(model);
                    model = new ParentModel();
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
