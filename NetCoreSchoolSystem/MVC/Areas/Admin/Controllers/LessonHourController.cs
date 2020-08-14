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
    public class LessonHourController : Controller
    {
        private readonly ILessonHourService lessonHourService;

        public LessonHourController(ILessonHourService lessonHourService)
        {
            this.lessonHourService = lessonHourService;
        }

        // GET: LessonHour
        public ActionResult Index()
        {
            return View(lessonHourService.GetActiveHour());
        }

        // GET: LessonHour/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LessonHour/Create
        public ActionResult Create()
        {
            ViewBag.MainHour = lessonHourService.GetActiveHour().Select(x => new SelectListItem() { Text = x.LesHour, Value = x.ID.ToString() });
            return View();
        }

        // POST: LessonHour/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LessonHour model)
        {
            if (ModelState.IsValid)
            {
                lessonHourService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: LessonHour/Edit/5
        public ActionResult Edit(Guid id)
        {
            LessonHour hour = lessonHourService.GetById(id);
            ViewBag.MainHour = lessonHourService.GetActiveHour().Select(x => new SelectListItem() { Text = x.LesHour, Value = x.ID.ToString() });
            return View(hour);
        }

        // POST: LessonHour/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LessonHour model)
        {
            if (ModelState.IsValid)
            {
                lessonHourService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: LessonHour/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(lessonHourService.GetById(id));
        }

        // POST: LessonHour/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(LessonHour hour)
        {
            try
            {
                lessonHourService.Remove(hour.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}