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
    public class NoteController : Controller
    {
        private readonly INoteEntryService noteEntryService;
        private readonly ITeacherService teacherService;
        private readonly IPeriodInformationService periodInformationService;
        private readonly IClassRoomService classRoomService;
        private readonly IStudentService studentService;
        private readonly ILessonService lessonService;

        public NoteController(INoteEntryService noteEntryService, ITeacherService teacherService, IPeriodInformationService periodInformationService, IClassRoomService classRoomService, IStudentService studentService, ILessonService lessonService)
        {
            this.noteEntryService = noteEntryService;
            this.teacherService = teacherService;
            this.periodInformationService = periodInformationService;
            this.classRoomService = classRoomService;
            this.studentService = studentService;
            this.lessonService = lessonService;
        }

        // GET: Note
        public ActionResult Index()
        {
            NoteVM noteVM = new NoteVM();
            noteVM.NoteEntries = noteEntryService.GetActiveNote();
            noteVM.ClassRooms = classRoomService.GetActiveRoom();
            noteVM.Teachers = teacherService.GetActiveTeacher();
            noteVM.PeriodInformations = periodInformationService.GetActivePeriodInformation();
            noteVM.Students = studentService.GetActiveStudent();
            noteVM.Lessons = lessonService.GetActiveLesson();
            return View(noteVM);
        }

        // GET: Note/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Note/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Note/Create
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

        // GET: Note/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Note/Edit/5
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

        // GET: Note/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Note/Delete/5
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