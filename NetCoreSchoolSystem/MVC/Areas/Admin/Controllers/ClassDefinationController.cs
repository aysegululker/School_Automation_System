using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity.OneToMany;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Areas.Admin.Models.ViewModels;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ClassDefinationController : Controller
    {
        private readonly IClassDefinationService classDefinationService;
        private readonly IClassRoomService classRoomService;
        private readonly IPeriodInformationService periodInformationService;

        public ClassDefinationController(IClassDefinationService classDefinationService, IClassRoomService classRoomService, IPeriodInformationService periodInformationService)
        {
            this.classDefinationService = classDefinationService;
            this.classRoomService = classRoomService;
            this.periodInformationService = periodInformationService;
        }

        // GET: ClassDefination
        public ActionResult Index()
        {
            ClassDefinationVM classDefinationVM = new ClassDefinationVM();
            classDefinationVM.PeriodInformations = periodInformationService.GetActivePeriodInformation();
            classDefinationVM.ClassDefinations = classDefinationService.GetActiveClDef();
            classDefinationVM.ClassRooms = classRoomService.GetActiveRoom();
            return View(classDefinationVM);
        }

        // GET: ClassDefination/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClassDefination/Create
        public ActionResult Create()
        {
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            ViewBag.MainPeriod = periodInformationService.GetActivePeriodInformation().GroupBy(ind => new { ind.LessonYear }).Select(x => new SelectListItem() { Text = x.First().LessonYear, Value = x.First().ID.ToString() });
            return View();
        }

        // POST: ClassDefination/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClassDefination classDefination)
        {
            if (ModelState.IsValid)
            {
                classDefinationService.Add(classDefination);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: ClassDefination/Edit/5
        public ActionResult Edit(Guid id)
        {
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            ViewBag.MainPeriod = periodInformationService.GetActivePeriodInformation().GroupBy(ind => new { ind.LessonYear }).Select(x => new SelectListItem() { Text = x.First().LessonYear, Value = x.First().ID.ToString() });
            return View(classDefinationService.GetById(id));
        }

        // POST: ClassDefination/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClassDefination classDefination)
        {
            if (ModelState.IsValid)
            {
                classDefinationService.Update(classDefination);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: ClassDefination/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(classDefinationService.GetById(id));
        }

        // POST: ClassDefination/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ClassDefination classDefination)
        {
            try
            {
                classDefinationService.Remove(classDefination.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}