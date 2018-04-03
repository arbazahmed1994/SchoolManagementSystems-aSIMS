using aSIMS.Models;
using aSIMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aSIMS.Controllers
{
    public class TransportController : Controller
    {
        TransportRepository _rep = new TransportRepository();

        public ActionResult Index()
        {
            @ViewBag.Main = "List";
            @ViewBag.Sub = "Transport";
            IEnumerable<TransportModel> model = _rep.Get();
            return View(model);
        }

        public ActionResult Create()
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Transport";
            return View(new TransportModel());
        }
        [HttpPost]
        public ActionResult Create(TransportModel model)
        {
            @ViewBag.Main = "Registration";
            @ViewBag.Sub = "Transport";

            if (ModelState.IsValid)
            {
                try
                {
                    model.EntryUser = (int)Session["UserID"];
                    _rep.Create(model);
                    model = new TransportModel();
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
            @ViewBag.Sub = "Transport";

            TransportModel model = new TransportModel();
            model = _rep.Get(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(TransportModel model)
        {
            @ViewBag.Main = "Updation";
            @ViewBag.Sub = "Transport";

            if (ModelState.IsValid)
            {
                try
                {
                    model.EntryUser = (int)Session["UserID"];
                    _rep.Edit(model);
                    model = new TransportModel();
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
            _rep.DeleteTwoSPName = "DeleteTransport";
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
