using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Areas.Ogretmen.Models.ViewModels;

namespace MVC.Areas.Ogretmen.Controllers
{   
    [Area("Ogretmen")]
    [Authorize(Roles = "Ogretmen")]
    public class NoteEntryController : Controller
    {
        private readonly INoteEntryService noteEntryService;
        private readonly ITeacherService teacherService;
        private readonly IPeriodInformationService periodInformationService;
        private readonly IClassRoomService classRoomService;
        private readonly IStudentService studentService;
        private readonly ILessonService lessonService;

        public NoteEntryController(INoteEntryService noteEntryService, ITeacherService teacherService, IPeriodInformationService periodInformationService, IClassRoomService classRoomService, IStudentService studentService, ILessonService lessonService)
        {
            this.noteEntryService = noteEntryService;
            this.teacherService = teacherService;
            this.periodInformationService = periodInformationService;
            this.classRoomService = classRoomService;
            this.studentService = studentService;
            this.lessonService = lessonService;
        }
       
        // GET: NoteEntry
        public ActionResult Index()
        {
            NoteEntryVM noteEntryVM = new NoteEntryVM();
            noteEntryVM.NoteEntries = noteEntryService.GetActiveNote();
            noteEntryVM.Teachers = teacherService.GetActiveTeacher();
            noteEntryVM.PeriodInformations = periodInformationService.GetActivePeriodInformation();
            noteEntryVM.ClassRooms = classRoomService.GetActiveRoom();
            noteEntryVM.Students = studentService.GetActiveStudent();
            noteEntryVM.Lessons = lessonService.GetActiveLesson();
            return View(noteEntryVM);
        }

        // GET: NoteEntry/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NoteEntry/Create
        public ActionResult Create()
        {
            ViewBag.MainTeachers = teacherService.GetActiveTeacher().Select(x => new SelectListItem() { Text = x.FullName, Value = x.ID.ToString() });
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            ViewBag.MainStudent = studentService.GetActiveStudent().Select(x => new SelectListItem() { Text = x.FullName, Value = x.ID.ToString() });
            ViewBag.MainLesson = lessonService.GetActiveLesson().Select(x => new SelectListItem() { Text = x.LessonName, Value = x.ID.ToString() });
            ViewBag.MainPerDonem = periodInformationService.GetActivePeriodInformation().Select(x => new SelectListItem() { Text = x.YearPeriod, Value = x.ID.ToString() });

            return View();
        }

        // POST: NoteEntry/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoteEntry noteEntry)
        {
            if (ModelState.IsValid)
            {
                Lesson lesson = new Lesson();
                if (lesson.ID == noteEntry.LessonID)
                {
                    var sinav1katsayi = lesson.MidTermNoteWeight1;
                    var sinav2katsayi = lesson.MidTermNoteWeight2;
                    var sinav3katsayi = lesson.FinalExamNoteWeight;

                    noteEntry.AverageScore = noteEntry.MidTermExam1Score * sinav1katsayi + noteEntry.MidTermExam2Score * sinav2katsayi + noteEntry.FinalExamScore * sinav3katsayi;
                }
                //noteEntry.AverageScore = (noteEntry.MidTermExam1Score * 0.35m + noteEntry.MidTermExam2Score * 0.30m + noteEntry.FinalExamScore * 0.35m);
                noteEntryService.Add(noteEntry);
                return RedirectToAction("DetayOgrenci", "ClassRoom");
            }
            else
            {
                return View();
            }
        }

        // GET: NoteEntry/Edit/5
        public ActionResult Edit(Guid id)
        {
            ViewBag.MainTeachers = teacherService.GetActiveTeacher().Select(x => new SelectListItem() { Text = x.FullName, Value = x.ID.ToString() });
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            ViewBag.MainStudent = studentService.GetActiveStudent().Select(x => new SelectListItem() { Text = x.FullName, Value = x.ID.ToString() });
            ViewBag.MainLesson = lessonService.GetActiveLesson().Select(x => new SelectListItem() { Text = x.LessonName, Value = x.ID.ToString() });
            ViewBag.MainPerDonem = periodInformationService.GetActivePeriodInformation().Select(x => new SelectListItem() { Text = x.YearPeriod, Value = x.ID.ToString() });
            return View(noteEntryService.GetById(id));
        }

        // POST: NoteEntry/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NoteEntry noteEntry)
        {
            if (ModelState.IsValid)
            {
                //Lesson lesson = new Lesson();
                //if (lesson.ID == noteEntry.LessonID)
                //{
                //    var sinav1katsayi = lesson.MidTermNoteWeight1;
                //    var sinav2katsayi = lesson.MidTermNoteWeight2;
                //    var sinav3katsayi = lesson.FinalExamNoteWeight;

                //    noteEntry.AverageScore = noteEntry.MidTermExam1Score * sinav1katsayi + noteEntry.MidTermExam2Score * sinav2katsayi + noteEntry.FinalExamScore * sinav3katsayi;
                //}
                noteEntry.AverageScore = (noteEntry.MidTermExam1Score * 0.35m + noteEntry.MidTermExam2Score * 0.30m + noteEntry.FinalExamScore * 0.35m);
                noteEntryService.Update(noteEntry);
                return RedirectToAction("DetayOgrenci", "ClassRoom");
            }
            else
            {
                return View();
            }
        }

        // GET: NoteEntry/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NoteEntry/Delete/5
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