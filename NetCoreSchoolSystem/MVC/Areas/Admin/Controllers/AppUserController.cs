using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC.Areas.Admin.Models.ViewModels;

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")] => Kullanıcı oluşturabilmek için Role ataması yapılmamıştır.
    public class AppUserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly AppDbContext context;
        private readonly RoleManager<AppUserRole> roleManager;

        public AppUserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext context, RoleManager<AppUserRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        // GET: Account/Create
        public ActionResult Create()
        {

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(AppUserVM appUserVM)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    FirstName = appUserVM.FirstName,
                    SurName = appUserVM.SurName,
                    UserName = appUserVM.UserName,
                    PasswordHash = appUserVM.Password,
                    IdentificationNumber = appUserVM.IdentificationNumber,
                    MemberStatus = appUserVM.MemberStatus,
                };
                var result = await userManager.CreateAsync(user, appUserVM.Password);

                if (result.Succeeded)
                {
                    //await context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AssignAdmin(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            await userManager.AddToRoleAsync(user, "Admin");
            user.MemberStatus = "Yönetim";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AssignOgretmen(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            await userManager.RemoveFromRoleAsync(user, "Admin");
            await userManager.RemoveFromRoleAsync(user, "Ogrenci");
            await userManager.AddToRoleAsync(user, "Ogretmen");
            user.MemberStatus = "Öğretmen";
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AssignOgrenci(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            await userManager.RemoveFromRoleAsync(user, "Admin");
            await userManager.RemoveFromRoleAsync(user, "Ogretmen");
            await userManager.AddToRoleAsync(user, "Ogrenci");
            user.MemberStatus = "Öğrenci";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

            }

            ModelState.AddModelError("", "User Not Found");
            return View("Index", userManager.Users);
        }


    }
}