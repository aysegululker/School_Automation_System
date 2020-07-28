using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity.OneToMany;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClassRoomController : Controller
    {
        private readonly IClassRoomService classRoomService;

        public ClassRoomController(IClassRoomService classRoomService)
        {
            this.classRoomService = classRoomService;
        }

        // GET: ClassRoom
        public ActionResult Index()
        {
            return View(classRoomService.GetActiveRoom());
        }

        // GET: ClassRoom/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClassRoom/Create
        public ActionResult Create()
        {
            ViewBag.MainClass = classRoomService.GetActiveRoom().GroupBy(ind => new {ind.Room }).Select(x => new SelectListItem() { Text = x.First().Room, Value = x.First().ID.ToString() });
            return View();
        }

        // POST: ClassRoom/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClassRoom model)
        {
            if (ModelState.IsValid)
            {
                classRoomService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: ClassRoom/Edit/5
        public ActionResult Edit(Guid id)
        {
            ClassRoom classRoom = classRoomService.GetById(id);
            ViewBag.MainClass = classRoomService.GetActiveRoom().GroupBy(ind => new { ind.Room }).Select(x => new SelectListItem() { Text = x.First().Room, Value = x.First().ID.ToString() });
            return View(classRoom);
        }

        // POST: ClassRoom/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClassRoom model)
        {
            if (ModelState.IsValid)
            {
                classRoomService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: ClassRoom/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(classRoomService.GetById(id));
        }

        // POST: ClassRoom/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ClassRoom model)
        {
            try
            {
                classRoomService.Remove(model.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}