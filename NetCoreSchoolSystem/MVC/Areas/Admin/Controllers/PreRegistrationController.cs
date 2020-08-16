using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BLL.Abstract;
using DAL.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Areas.Admin.Models.ViewModels;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PreRegistrationController : Controller
    {
        private readonly IPreRegistrationService preRegistrationService;
        private readonly IPeriodInformationService periodInformationService;
        private readonly IClassRoomService classRoomService;
        private readonly IStudentService studentService;

        public PreRegistrationController(IPreRegistrationService preRegistrationService, IPeriodInformationService periodInformationService, IClassRoomService classRoomService, IStudentService studentService)
        {
            this.preRegistrationService = preRegistrationService;
            this.periodInformationService = periodInformationService;
            this.classRoomService = classRoomService;
            this.studentService = studentService;
        }

        // GET: PreRegistration
        public ActionResult Index()
        {
            //return View(preRegistrationService.GetActiveRegis());
            PreRegistrationVM preRegistrationVM = new PreRegistrationVM();
            preRegistrationVM.PeriodInformations = periodInformationService.GetActivePeriodInformation();
            preRegistrationVM.PreRegistrations = preRegistrationService.GetActiveRegis();
            preRegistrationVM.ClassRooms = classRoomService.GetActiveRoom();
            return View(preRegistrationVM);
        }

        // GET: PreRegistration/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PreRegistration/Create
        public ActionResult Create()
        {
            ViewBag.MainPeriod = periodInformationService.GetActivePeriodInformation().GroupBy(ind => new { ind.LessonYear }).Select(x => new SelectListItem() { Text = x.First().LessonYear, Value = x.First().ID.ToString() });
            ViewBag.MainClass = classRoomService.GetActiveRoom().GroupBy(ind => new { ind.Room }).Select(x => new SelectListItem() { Text = x.First().Room, Value = x.First().ID.ToString() });
            return View();
        }

        // POST: PreRegistration/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PreRegistration preRegistration, IFormFile image)
        {
            try
            {
                string path;
                if (image == null && preRegistration.Gender == "Kız")
                {

                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", "kizogrenci.jpg");
                    preRegistration.ImagePath = "kizogrenci.jpg";

                }
                else if (image == null && preRegistration.Gender == "Erkek")
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", "erkekogrenci.png");
                    preRegistration.ImagePath = "erkekogrenci.png";
                }
                else
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", image.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }
                    preRegistration.ImagePath = image.FileName;
                }

                preRegistrationService.Add(preRegistration);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        // GET: PreRegistration/Edit/5
        public ActionResult Edit(Guid id)
        {
            ViewBag.MainPeriod = periodInformationService.GetActivePeriodInformation().GroupBy(ind => new { ind.LessonYear }).Select(x => new SelectListItem() { Text = x.First().LessonYear, Value = x.First().ID.ToString() });
            ViewBag.MainClass = classRoomService.GetActiveRoom().GroupBy(ind => new { ind.Room }).Select(x => new SelectListItem() { Text = x.First().Room, Value = x.First().ID.ToString() });
            return View(preRegistrationService.GetById(id));
        }

        // POST: PreRegistration/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PreRegistration preRegistration, IFormFile image)
        {
            try
            {
                string path;
                if (image == null && preRegistration.Gender == "Kız")
                {
                    if (preRegistration.ImagePath != null)
                    {
                        preRegistrationService.Update(preRegistration);
                        return RedirectToAction("Index");
                    }
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", "kizogrenci.jpg");
                    preRegistration.ImagePath = "kizogrenci.jpg";
                }
                else if (image == null && preRegistration.Gender == "Erkek")
                {
                    if (preRegistration.ImagePath != null)
                    {
                        preRegistrationService.Update(preRegistration);
                        return RedirectToAction("Index");
                    }
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", "erkekogrenci.png");
                    preRegistration.ImagePath = "erkekogrenci.png";
                }
                else
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", image.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }
                    preRegistration.ImagePath = image.FileName;
                }
                preRegistrationService.Update(preRegistration);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }


        // GET: PreRegistration/Edit/5
        public ActionResult CreatStudent(Guid id)
        {
            ViewBag.MainPeriod = periodInformationService.GetActivePeriodInformation().GroupBy(ind => new { ind.LessonYear }).Select(x => new SelectListItem() { Text = x.First().LessonYear, Value = x.First().ID.ToString() });
            ViewBag.MainClass = classRoomService.GetActiveRoom().GroupBy(ind => new { ind.Room }).Select(x => new SelectListItem() { Text = x.First().Room, Value = x.First().ID.ToString() });
            ViewBag.MainRoom = classRoomService.GetActiveRoom().Select(x => new SelectListItem() { Text = x.RoomDepartment, Value = x.ID.ToString() });
            return View(preRegistrationService.GetById(id));
        }

        // POST: PreRegistration/CreatStudent/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreatStudent(Student student, IFormFile image, PreRegistration preRegistration)
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
                studentService.Add(student);
                preRegistrationService.Remove(preRegistration.ID);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }



        // GET: PreRegistration/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(preRegistrationService.GetById(id));
        }

        // POST: PreRegistration/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(PreRegistration preRegistration)
        {

            try
            {
                preRegistrationService.Remove(preRegistration.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}