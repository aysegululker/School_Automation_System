using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SuccessDocumentIdentificationController : Controller
    {
        private readonly ISuccessDocumentIdentificationService successDocumentIdentificationService;

        public SuccessDocumentIdentificationController(ISuccessDocumentIdentificationService successDocumentIdentificationService)
        {
            this.successDocumentIdentificationService = successDocumentIdentificationService;
        }

        // GET: SuccessDocumentIdentification
        public ActionResult Index()
        {
            return View(successDocumentIdentificationService.GetActiveSucDocument());
        }

        // GET: SuccessDocumentIdentification/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuccessDocumentIdentification/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuccessDocumentIdentification/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuccessDocumentIdentification model)
        {
            if (ModelState.IsValid)
            {
                successDocumentIdentificationService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: SuccessDocumentIdentification/Edit/5
        public ActionResult Edit(Guid id)
        {
            SuccessDocumentIdentification success = successDocumentIdentificationService.GetById(id);
            return View(success);
        }

        // POST: SuccessDocumentIdentification/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SuccessDocumentIdentification model)
        {
            if (ModelState.IsValid)
            {
                successDocumentIdentificationService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: SuccessDocumentIdentification/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(successDocumentIdentificationService.GetById(id));
        }

        // POST: SuccessDocumentIdentification/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(SuccessDocumentIdentification success)
        {
            try
            {
                successDocumentIdentificationService.Remove(success.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}