using Core;
using Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Repo;
using Repo.ViewModels;
using System.Security.Cryptography;
using Web.CustFilter;

namespace Web.Areas.CompanyArea.Controllers
{
    [CompanyAuth]
    [Area("CompanyArea")]
    public class ProjectTaskAssignmentController : Controller
    {
        IProjectTaskAssignmentRepo repo;
        IProjectRepo prepo;

        public ProjectTaskAssignmentController(IProjectTaskAssignmentRepo repo, IProjectRepo prepo)
        {
            this.repo = repo;
            this.prepo = prepo;
        }
        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public IActionResult ProjectTaskAssignment(Int64 id)
        {
            ViewBag.SelectedApplicationId = id;
            return View();
        }

        [HttpPost]
        public IActionResult ProjectAssignment(ProjectTaskAssignment rec)
        {
            if (ModelState.IsValid)
            {
                this.repo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
    }
}
