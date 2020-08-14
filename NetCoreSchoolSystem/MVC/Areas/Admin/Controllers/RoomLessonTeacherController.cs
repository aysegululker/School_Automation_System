using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity.ManyToMany;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Areas.Admin.Models.ViewModels;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoomLessonTeacherController : Controller
    {
        private readonly IRoomLessonTeacherService roomLessonTeacherService;
        private readonly IClassRoomService classRoomService;
        private readonly ILessonService lessonService;
        private readonly ITeacherService teacherService;
        private readonly IBranchService branchService;

        public RoomLessonTeacherController(IRoomLessonTeacherService roomLessonTeacherService,IClassRoomService classRoomService, ILessonService lessonService, ITeacherService teacherService, IBranchService branchService)
        {
            this.roomLessonTeacherService = roomLessonTeacherService;
            this.classRoomService = classRoomService;
            this.lessonService = lessonService;
            this.teacherService = teacherService;
            this.branchService = branchService;
        }

        // GET: RoomLessonTeacher
        public ActionResult Index()
        {
            RoomLessonTeacherVM roomLessonTeacherVM = new RoomLessonTeacherVM();
            roomLessonTeacherVM.RoomLessonTeachers = roomLessonTeacherService.GetActiveRoomLessonTeacher();
            roomLessonTeacherVM.ClassRooms = classRoomService.GetActiveRoom();
            roomLessonTeacherVM.Lessons = lessonService.GetActiveLesson();
            roomLessonTeacherVM.Teachers = teacherService.GetActiveTeacher();
            roomLessonTeacherVM.Branches = branchService.GetActiveBranch();
            return View(roomLessonTeacherVM);
        }

        // GET: RoomLessonTeacher/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoomLessonTeacher/Create
        public ActionResult Create()
        {
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            ViewBag.MainLesson = lessonService.GetActiveLesson().Select(x => new SelectListItem() { Text = x.LessonName, Value = x.ID.ToString() });
            ViewBag.MainTeachers = teacherService.GetActiveTeacher().Select(x => new SelectListItem() { Text = x.FullName, Value = x.ID.ToString() });
            ViewBag.MainBranches = branchService.GetActiveBranch().Select(x => new SelectListItem() { Text = x.BranchName, Value = x.ID.ToString() });
            return View();
        }

        // POST: RoomLessonTeacher/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RoomLessonTeacher roomLessonTeacher)
        {
            if (ModelState.IsValid)
            {
                roomLessonTeacherService.Add(roomLessonTeacher);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: RoomLessonTeacher/Edit/5
        public ActionResult Edit(Guid id)
        {
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            ViewBag.MainLesson = lessonService.GetActiveLesson().Select(x => new SelectListItem() { Text = x.LessonName, Value = x.ID.ToString() });
            ViewBag.MainTeachers = teacherService.GetActiveTeacher().Select(x => new SelectListItem() { Text = x.FullName, Value = x.ID.ToString() });
            ViewBag.MainBranches = branchService.GetActiveBranch().Select(x => new SelectListItem() { Text = x.BranchName, Value = x.ID.ToString() });
            return View(roomLessonTeacherService.GetById(id));
        }

        // POST: RoomLessonTeacher/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RoomLessonTeacher roomLessonTeacher)
        {
            if (ModelState.IsValid)
            {
                roomLessonTeacherService.Update(roomLessonTeacher);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: RoomLessonTeacher/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(roomLessonTeacherService.GetById(id));
        }

        // POST: RoomLessonTeacher/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(RoomLessonTeacher roomLessonTeacher)
        {
            try
            {
                roomLessonTeacherService.Remove(roomLessonTeacher.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}