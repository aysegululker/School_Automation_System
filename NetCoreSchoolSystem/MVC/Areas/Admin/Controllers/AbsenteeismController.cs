using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Areas.Admin.Models.ViewModels;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
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
            AbsenteeismVM absenteeismVM = new AbsenteeismVM();
            absenteeismVM.Absenteeisms = absenteeismService.GetActiveAbsenteeism();
            absenteeismVM.Students = studentService.GetActiveStudent();
            absenteeismVM.ClassRooms = classRoomService.GetActiveRoom();
            return View(absenteeismVM);
        }

        // GET: Absenteeism/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Absenteeism/Create
        public ActionResult Create()
        {
            ViewBag.MainStudent = studentService.GetActiveStudent().Select(x => new SelectListItem() { Text = x.FullName, Value = x.ID.ToString() });
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            return View();
        }

        // POST: Absenteeism/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Absenteeism absenteeism)
        {
            if (ModelState.IsValid)
            {
                absenteeismService.Add(absenteeism);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Absenteeism/Edit/5
        public ActionResult Edit(Guid id)
        {
            ViewBag.MainStudent = studentService.GetActiveStudent().Select(x => new SelectListItem() { Text = x.FullName, Value = x.ID.ToString() });
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            return View(absenteeismService.GetById(id));
        }

        // POST: Absenteeism/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Absenteeism absenteeism)
        {
            if (ModelState.IsValid)
            {
                absenteeismService.Update(absenteeism);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Absenteeism/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(absenteeismService.GetById(id));
        }

        // POST: Absenteeism/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Absenteeism absenteeism)
        {
            try
            {
                absenteeismService.Remove(absenteeism.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}