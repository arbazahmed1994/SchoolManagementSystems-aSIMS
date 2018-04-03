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
    public class ClassesController : Controller
    {

        ClassesRepository _rep = new ClassesRepository();

        public ActionResult Index()
        {
            @ViewBag.Main = "List";
            @ViewBag.Sub = "Classes";
            IEnumerable<ClassesModel> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Classes";
            return View(new ClassesModel());
        }
        [HttpPost]
        public ActionResult Create(ClassesModel model)
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Classes";

            if (ModelState.IsValid)
            {
                try
                {
                    _rep.Create(model);
                    model = new ClassesModel();
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
            @ViewBag.Sub = "Classes";

            ClassesModel model = new ClassesModel();
            model = _rep.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ClassesModel model)
        {
            @ViewBag.Main = "Updation";
            @ViewBag.Sub = "Classes";

            if (ModelState.IsValid)
            {
                try
                {
                    _rep.Edit(model);
                    model = new ClassesModel();
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


        // ====================== SECTION CONTROLLER =========================================


        SectionsRepository _sectionRep = new SectionsRepository();

        public ActionResult SectionIndex()
        {
            @ViewBag.Main = "List";
            @ViewBag.Sub = "Sections";
            IEnumerable<SectionsModel> model = _sectionRep.Get();
            return View(model);
        }

        public ActionResult SectionCreate()
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Sections";
            return View(new SectionsModel());
        }
        [HttpPost]
        public ActionResult SectionCreate(SectionsModel model)
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Sections";

            if (ModelState.IsValid)
            {
                try
                {
                    _sectionRep.Create(model);
                    model = new SectionsModel();
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

        public ActionResult SectionEdit(int id)
        {
            @ViewBag.Main = "Updation";
            @ViewBag.Sub = "Sections";

            SectionsModel model = new SectionsModel();
            model = _sectionRep.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult SectionEdit(SectionsModel model)
        {
            @ViewBag.Main = "Updation";
            @ViewBag.Sub = "Sections";

            if (ModelState.IsValid)
            {
                try
                {
                    _sectionRep.Edit(model);
                    model = new SectionsModel();
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

        public ActionResult SectionDelete(int id)
        {
            if (_sectionRep.Delete(id) == 1)
            {
                TempData["Message"] = "success";
                TempData["SuccessMessage"] = MessageNaming.SuccessDataDelete;
            }
            else
            {
                TempData["Message"] = "error";
                TempData["ErrorMessage"] = MessageNaming.ErrorDataDelete;
            }
            return RedirectToAction("SectionIndex");
        }

    }
}
