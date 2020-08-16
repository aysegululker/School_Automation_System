using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Context;
using DAL.Entity;
using DAL.Entity.ManyToMany;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Areas.Admin.Models.ViewModels;
using MVC.Areas.Ogretmen.Models.ViewModels;

namespace MVC.Areas.Ogretmen.Controllers
{
    [Area("Ogretmen")]
    public class ClassRoomController : Controller
    {
        private readonly AppDbContext context;
        private readonly IRoomLessonTeacherService roomLessonTeacherService;
        private readonly ITeacherService teacherService;
        private readonly IClassRoomService classRoomService;
        private readonly UserManager<AppUser> userManager;
        private readonly INoteEntryService noteEntryService;
        private readonly IPeriodInformationService periodInformationService;
        private readonly IStudentService studentService;
        private readonly ILessonService lessonService;

        public ClassRoomController(AppDbContext context ,IRoomLessonTeacherService roomLessonTeacherService, ITeacherService teacherService, IClassRoomService classRoomService, UserManager<AppUser> userManager, INoteEntryService noteEntryService, IPeriodInformationService periodInformationService, IStudentService studentService, ILessonService lessonService)
        {
            this.context = context;
            this.roomLessonTeacherService = roomLessonTeacherService;
            this.teacherService = teacherService;
            this.classRoomService = classRoomService;
            this.userManager = userManager;
            this.noteEntryService = noteEntryService;
            this.periodInformationService = periodInformationService;
            this.studentService = studentService;
            this.lessonService = lessonService;
        }

        // GET: ClassRoom
        public ActionResult Index()
        {

            return View(classRoomService.GetActiveRoom());
        }

        // GET: ClassRoom/Details/5
        public ActionResult Details(Guid id)
        {
            RoomLessonTeacherEkVM roomLessonTeacherEkVM = new RoomLessonTeacherEkVM();
            roomLessonTeacherEkVM.RoomLessonTeachers = roomLessonTeacherService.GetActiveRoomLessonTeacher();
            roomLessonTeacherEkVM.ClassRooms = classRoomService.GetActiveRoom();
            roomLessonTeacherEkVM.Lessons = lessonService.GetActiveLesson();
            roomLessonTeacherEkVM.Teachers = teacherService.GetActiveTeacher();

            var sonuc = roomLessonTeacherEkVM.ClassRooms.Where(x => x.ID == id).ToList();
            return View(roomLessonTeacherEkVM);
        }

        // GET: ClassRoom/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassRoom/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ClassRoom/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: ClassRoom/Edit/5
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

        // GET: ClassRoom/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: ClassRoom/Delete/5
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

        // GET: ClassRoom/DetaySinif/5
        public ActionResult DetaySinif(Guid guid)
        {
            DetaySinifVM detaySinifVM = new DetaySinifVM();
            detaySinifVM.ClassRooms = classRoomService.GetActiveRoom();
            detaySinifVM.Students = studentService.GetActiveStudent();
            return View(detaySinifVM);
        }

        // GET: ClassRoom/DetayOgrenci/5
        public ActionResult DetayOgrenci(Guid id)
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
    }
}