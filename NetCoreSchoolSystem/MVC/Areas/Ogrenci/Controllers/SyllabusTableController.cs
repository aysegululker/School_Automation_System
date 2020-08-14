using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Areas.Ogrenci.Models.ViewModels;

namespace MVC.Areas.Ogrenci.Controllers
{
    [Area("Ogrenci")]
    public class SyllabusTableController : Controller
    {
        private readonly ITeacherService teacherService;
        private readonly ISyllabusTableService syllabusTableService;
        private readonly IClassRoomService classRoomService;
        private readonly ILessonService lessonService;
        private readonly ILessonHourService lessonHourService;
        private readonly IStudentService studentService;

        public SyllabusTableController(ITeacherService teacherService, ISyllabusTableService syllabusTableService, IClassRoomService classRoomService, ILessonService lessonService, ILessonHourService lessonHourService, IStudentService studentService)
        {
            this.teacherService = teacherService;
            this.syllabusTableService = syllabusTableService;
            this.classRoomService = classRoomService;
            this.lessonService = lessonService;
            this.lessonHourService = lessonHourService;
            this.studentService = studentService;
        }

        // GET: SyllabusTable
        public ActionResult Index()
        {
            StudentSyllabusTableVM studentSyllabusTableVM = new StudentSyllabusTableVM();
            studentSyllabusTableVM.Teachers = teacherService.GetActiveTeacher();
            studentSyllabusTableVM.SyllabusTables = syllabusTableService.GetActiveSyllabus();
            studentSyllabusTableVM.ClassRooms = classRoomService.GetActiveRoom();
            studentSyllabusTableVM.Lessons = lessonService.GetActiveLesson();
            studentSyllabusTableVM.LessonHours = lessonHourService.GetActiveHour();
            studentSyllabusTableVM.Students = studentService.GetSyllabusStudent();
            return View(studentSyllabusTableVM);
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
                // TODO: Add update logic here

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
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}