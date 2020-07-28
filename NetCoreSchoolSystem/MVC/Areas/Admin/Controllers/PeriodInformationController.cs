using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PeriodInformationController : Controller
    {
        private readonly IPeriodInformationService periodInformationService;

        public PeriodInformationController(IPeriodInformationService periodInformationService)
        {
            this.periodInformationService = periodInformationService;
        }

        // GET: PeriodInformation
        public ActionResult Index()
        {
            return View(periodInformationService.GetActivePeriodInformation());
        }

        // GET: PeriodInformation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PeriodInformation/Create
        public ActionResult Create()
        {
            ViewBag.MainPeriod = periodInformationService.GetActivePeriodInformation().Select(x => new SelectListItem() { Text = x.LessonYear, Value = x.ID.ToString() });
            return View();
        }

        // POST: PeriodInformation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PeriodInformation model)
        {
            if (ModelState.IsValid)
            {
                periodInformationService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: PeriodInformation/Edit/5
        public ActionResult Edit(Guid id)
        {
            PeriodInformation periodInformation = periodInformationService.GetById(id);
            return View(periodInformation);
        }

        // POST: PeriodInformation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PeriodInformation periodInformation)
        {
            if (ModelState.IsValid)
            {
                periodInformationService.Update(periodInformation);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: PeriodInformation/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(periodInformationService.GetById(id));
        }

        // POST: PeriodInformation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PeriodInformation periodInformation)
        {
            try
            {
                periodInformationService.Remove(periodInformation.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}