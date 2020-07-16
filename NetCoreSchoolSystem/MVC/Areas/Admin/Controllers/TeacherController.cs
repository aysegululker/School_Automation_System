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
    public class TeacherController : Controller
    {
        private readonly ITeacherService teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            this.teacherService = teacherService;
        }

        // GET: Teacher
        public ActionResult Index()
        {
            return View(teacherService.GetActiveTeacher());
        }

        // GET: Teacher/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Teacher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teacher/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Teacher model)
        {
            if (ModelState.IsValid)
            {
                teacherService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Teacher/Edit/5
        public ActionResult Edit(Guid id)
        {
            Teacher teacher = teacherService.GetById(id);
            return View(teacher);
        }

        // POST: Teacher/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                teacherService.Update(teacher);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Teacher/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(teacherService.GetById(id));
        }

        // POST: Teacher/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Teacher teacher)
        {
            try
            {
                teacherService.Remove(teacher.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}