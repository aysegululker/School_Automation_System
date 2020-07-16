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
    public class LessonController : Controller
    {
        private readonly ILessonService lessonService;

        public LessonController(ILessonService lessonService)
        {
            this.lessonService = lessonService;
        }

        // GET: Lesson
        public ActionResult Index()
        {
            return View(lessonService.GetActiveLesson());
        }

        // GET: Lesson/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lesson/Create
        public ActionResult Create()
        {
            //Todo:Ders kategorisi enum'a bağlanacak.
            //ViewBag.Categoies = lessonService.GetActiveLesson().Select(x => new SelectListItem() { Text = x.LessonCategory.ToString(), Value = x.ID.ToString() });
            return View();
        }

        // POST: Lesson/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Lesson model)
        {
            if (ModelState.IsValid)
            {
                lessonService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Lesson/Edit/5
        public ActionResult Edit(Guid id)
        {
            Lesson lesson = lessonService.GetById(id);
            return View(lesson);
        }

        // POST: Lesson/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Lesson model)
        {
            if (ModelState.IsValid)
            {
                lessonService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Lesson/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(lessonService.GetById(id));
        }

        // POST: Lesson/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Lesson model)
        {
            try
            {
                lessonService.Remove(model.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}