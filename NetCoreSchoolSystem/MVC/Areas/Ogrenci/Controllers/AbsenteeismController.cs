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
    public class AbsenteeismController : Controller
    {
        private readonly IAbsenteeismService absenteeismService;
        private readonly IStudentService studentService;
        private readonly IClassRoomService classRoomService;

        public AbsenteeismController(IAbsenteeismService absenteeismService, IStudentService studentService, IClassRoomService classRoomService)
        {
            this.absenteeismService = absenteeismService;
            this.studentService = studentService;
            this.classRoomService = classRoomService;
        }

        // GET: Absenteeism
        public ActionResult Index()
        {
            StudentAbsenteeismVM studentAbsenteeismVM = new StudentAbsenteeismVM();
            studentAbsenteeismVM.Absenteeisms = absenteeismService.GetActiveAbsenteeism();
            studentAbsenteeismVM.Students = studentService.GetActiveStudent();
            studentAbsenteeismVM.ClassRooms = classRoomService.GetActiveRoom();
            return View(studentAbsenteeismVM);
        }

        // GET: Absenteeism/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Absenteeism/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Absenteeism/Create
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

        // GET: Absenteeism/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Absenteeism/Edit/5
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

        // GET: Absenteeism/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Absenteeism/Delete/5
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