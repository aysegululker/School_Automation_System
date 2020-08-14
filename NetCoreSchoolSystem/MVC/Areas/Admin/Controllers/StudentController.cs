using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Areas.Admin.Models.ViewModels;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;
        private readonly IClassRoomService classRoomService;
        private readonly IPreRegistrationService preRegistrationService;

        public StudentController(IStudentService studentService, IClassRoomService classRoomService, IPreRegistrationService preRegistrationService)
        {
            this.studentService = studentService;
            this.classRoomService = classRoomService;
            this.preRegistrationService = preRegistrationService;
        }

        // GET: Student
        public ActionResult Index()
        {
            StudentVM studentVM = new StudentVM();
            studentVM.Students = studentService.GetActiveStudent();
            studentVM.ClassRooms = classRoomService.GetActiveRoom();
            studentVM.PreRegistrations = preRegistrationService.GetActiveRegis();
            return View(studentVM);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create(Student student)
        {
            ViewBag.MainStudent = studentService.GetActiveStudent().Select(x => new SelectListItem() { Text = x.FullName, Value = x.ID.ToString() });
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Student student, IFormFile image)
        {
            try
            {
                string path;
                if (image == null && student.Gender == "Kız")
                {

                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", "kizogrenci.jpg");
                    student.ImagePath = "kizogrenci.jpg";

                }
                else if (image == null && student.Gender == "Erkek")
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", "erkekogrenci.png");
                    student.ImagePath = "erkekogrenci.png";
                }
                else
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", image.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }
                    student.ImagePath = image.FileName;
                }

                studentService.Add(student);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(Guid id)
        {
            ViewBag.MainStudent = studentService.GetActiveStudent().Select(x => new SelectListItem() { Text = x.FullName, Value = x.ID.ToString() });
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            return View(studentService.GetById(id));
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Student student, IFormFile image)
        {
            try
            {
                string path;
                if (image == null && student.Gender == "Kız")
                {
                    if (student.ImagePath != null)
                    {
                        studentService.Update(student);
                        return RedirectToAction("Index");
                    }
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", "kizogrenci.jpg");
                    student.ImagePath = "kizogrenci.jpg";
                }
                else if (image == null && student.Gender == "Erkek")
                {
                    if (student.ImagePath != null)
                    {
                        studentService.Update(student);
                        return RedirectToAction("Index");
                    }
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", "erkekogrenci.png");
                    student.ImagePath = "erkekogrenci.png";
                }
                else
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", image.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }
                    student.ImagePath = image.FileName;
                }
                studentService.Update(student);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(studentService.GetById(id));
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Student student)
        {
            try
            {
                studentService.Remove(student.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}