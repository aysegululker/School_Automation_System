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

namespace MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BranchController : Controller
    {
        private readonly IBranchService branchService;

        public BranchController(IBranchService branchService)
        {
            this.branchService = branchService;
        }

        // GET: Branch
        public ActionResult Index()
        {
            return View(branchService.GetActiveBranch());
        }

        // GET: Branch/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Branch/Create
        public ActionResult Create()
        {
            ViewBag.MainBranches = branchService.GetActiveBranch().Select(x => new SelectListItem() { Text = x.BranchName, Value = x.ID.ToString() });
            return View();
        }

        // POST: Branch/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Branch model)
        {
            if (ModelState.IsValid)
            {
                branchService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Branch/Edit/5
        public ActionResult Edit(Guid id)
        {
            Branch branch = branchService.GetById(id);
            return View(branch);
        }

        // POST: Branch/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Branch branch)
        {
            if (ModelState.IsValid)
            {
                branchService.Update(branch);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        // GET: Branch/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(branchService.GetById(id));
        }

        // POST: Branch/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Branch branch)
        {
            try
            {
                branchService.Remove(branch.ID);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}