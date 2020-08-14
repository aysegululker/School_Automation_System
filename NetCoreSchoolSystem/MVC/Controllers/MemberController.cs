using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVC.Models;

namespace MVC.Controllers
{
    public class MemberController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly AppDbContext context;

        public MemberController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AppUserLoginVM loginVM)//Kullanıcı adı ve şifre
        {
            if (ModelState.IsValid)
            {
                AppUser user = await userManager.FindByNameAsync(loginVM.UserName);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    var result = await signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        if (await userManager.IsInRoleAsync(user, "Admin"))
                        {
                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }
                        else if (await userManager.IsInRoleAsync(user, "Ogretmen"))
                        {
                            return RedirectToAction("Index", "Home", new { area = "Ogretmen" });
                        }
                        else if (await userManager.IsInRoleAsync(user, "Ogrenci"))
                        {
                            return RedirectToAction("Index", "Home", new { area = "Ogrenci" });
                        }
                    }
                }

            }
            return View();
        }


        public IActionResult LoginOut()
        {
            signInManager.SignOutAsync();
            return Redirect("~/Member/Login");
        }

    }
}