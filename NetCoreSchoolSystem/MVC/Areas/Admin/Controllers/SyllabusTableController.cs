using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using DAL.Entity.ManyToMany;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Areas.Admin.Models.ViewModels;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SyllabusTableController : Controller
    {
        private readonly ISyllabusTableService syllabusTableService;
        private readonly ILessonHourService lessonHourService;
        private readonly ILessonService lessonService;
        private readonly IClassRoomService classRoomService;
        private readonly ITeacherService teacherService;
        private readonly ITeacherSyllabusTableService teacherSyllabusTableService;

        public SyllabusTableController(ISyllabusTableService syllabusTableService, ILessonHourService lessonHourService, ILessonService lessonService, IClassRoomService classRoomService, ITeacherService teacherService, ITeacherSyllabusTableService teacherSyllabusTableService)
        {
            this.syllabusTableService = syllabusTableService;
            this.lessonHourService = lessonHourService;
            this.lessonService = lessonService;
            this.classRoomService = classRoomService;
            this.teacherService = teacherService;
            this.teacherSyllabusTableService = teacherSyllabusTableService;
        }

        // GET: SyllabusTable
        public ActionResult Index()
        {
            SyllabusTableVM syllabusTableVM = new SyllabusTableVM();
            syllabusTableVM.SyllabusTables = syllabusTableService.GetActiveSyllabus();
            syllabusTableVM.LessonHours = lessonHourService.GetActiveHour();
            syllabusTableVM.Lessons = lessonService.GetActiveLesson();
            syllabusTableVM.ClassRooms = classRoomService.GetActiveRoom();
            syllabusTableVM.Teachers = teacherService.GetActiveTeacher();
            return View(syllabusTableVM);
        }

        // GET: SyllabusTable/Details/5
        public ActionResult Details(Guid id)
        {
            SyllabusTableVM syllabusTableVM = new SyllabusTableVM();
            syllabusTableVM.SyllabusTables = syllabusTableService.GetActiveSyllabus();
            syllabusTableVM.LessonHours = lessonHourService.GetActiveHour();
            syllabusTableVM.Lessons = lessonService.GetActiveLesson();
            syllabusTableVM.ClassRooms = classRoomService.GetActiveRoom();
            syllabusTableVM.Teachers = teacherService.GetActiveTeacher();
            return View(syllabusTableVM);
        }

        // GET: SyllabusTable/Create
        public ActionResult Create()
        {
            ViewBag.MainHour = lessonHourService.GetActiveHour().Select(x => new SelectListItem() { Text = x.LesHour, Value = x.ID.ToString() });
            ViewBag.MainLesson = lessonService.GetActiveLesson().Select(x => new SelectListItem() { Text = x.LessonName, Value = x.ID.ToString() });
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            ViewBag.MainTeachers = teacherService.GetActiveTeacher().Select(x => new SelectListItem() { Text = x.FullName, Value = x.ID.ToString() });
            return View();
        }

        // POST: SyllabusTable/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SyllabusTable model)
        {
            if (ModelState.IsValid)
            {
                syllabusTableService.Add(model);

                TeacherSyllabusTable teacherSyllabusTable = new TeacherSyllabusTable()
                {
                    TeacherID = model.TeacherID,
                    SyllabusTableID = model.ID,
                };
                teacherSyllabusTableService.Add(teacherSyllabusTable);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: SyllabusTable/Edit/5
        public ActionResult Edit(Guid id)
        {
            ViewBag.MainHour = lessonHourService.GetActiveHour().Select(x => new SelectListItem() { Text = x.LesHour, Value = x.ID.ToString() });
            ViewBag.MainLesson = lessonService.GetActiveLesson().Select(x => new SelectListItem() { Text = x.LessonName, Value = x.ID.ToString() });
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            ViewBag.MainTeachers = teacherService.GetActiveTeacher().Select(x => new SelectListItem() { Text = x.FullName, Value = x.ID.ToString() });
            return View(syllabusTableService.GetById(id));
        }

        // POST: SyllabusTable/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SyllabusTable syllabusTable)
        {
            if (ModelState.IsValid)
            {
                syllabusTableService.Update(syllabusTable);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: SyllabusTable/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(syllabusTableService.GetById(id)); ;
        }

        // POST: SyllabusTable/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(SyllabusTable syllabusTable)
        {
            try
            {
                syllabusTableService.Remove(syllabusTable.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}