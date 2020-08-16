using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC.Areas.Ogretmen.Models.ViewModels;

namespace MVC.Areas.Ogretmen.Controllers
{
    [Area("Ogretmen")]
    public class SyllabusTableController : Controller
    {
        private readonly ITeacherSyllabusTableService teacherSyllabusTableService;
        private readonly ITeacherService teacherService;
        private readonly ISyllabusTableService syllabusTableService;
        private readonly IClassRoomService classRoomService;
        private readonly ILessonService lessonService;
        private readonly ILessonHourService lessonHourService;

        public SyllabusTableController(ITeacherSyllabusTableService teacherSyllabusTableService, ITeacherService teacherService, ISyllabusTableService syllabusTableService, IClassRoomService classRoomService, ILessonService lessonService, ILessonHourService lessonHourService)
        {
            this.teacherSyllabusTableService = teacherSyllabusTableService;
            this.teacherService = teacherService;
            this.syllabusTableService = syllabusTableService;
            this.classRoomService = classRoomService;
            this.lessonService = lessonService;
            this.lessonHourService = lessonHourService;
        }

        // GET: SyllabusTable
        public ActionResult Index()
        {
            
            TeacherSyllabusTableVM teacherSyllabusTableVM = new TeacherSyllabusTableVM();
            teacherSyllabusTableVM.TeacherSyllabusTables = teacherSyllabusTableService.GetActiveTeacherSyllabus();
            teacherSyllabusTableVM.Teachers = teacherService.GetActiveTeacher();
            teacherSyllabusTableVM.SyllabusTables = syllabusTableService.GetActiveSyllabus();
            teacherSyllabusTableVM.ClassRooms = classRoomService.GetActiveRoom();
            teacherSyllabusTableVM.LessonHours = lessonHourService.GetActiveHour();
            teacherSyllabusTableVM.Lessons = lessonService.GetActiveLesson();
            return View(teacherSyllabusTableVM);
        }

        // GET: SyllabusTable/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SyllabusTable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SyllabusTable/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SyllabusTable/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SyllabusTable/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SyllabusTable/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SyllabusTable/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}