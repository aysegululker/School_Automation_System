using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Ogrenci.Controllers
{
    [Area("Ogrenci")]
    [Authorize(Roles = "Ogrenci")]
    public class StudentSyllabusTableController : Controller
    {
        // GET: StudentSyllabusTable
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentSyllabusTable/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentSyllabusTable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentSyllabusTable/Create
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

        // GET: StudentSyllabusTable/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentSyllabusTable/Edit/5
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

        // GET: StudentSyllabusTable/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentSyllabusTable/Delete/5
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