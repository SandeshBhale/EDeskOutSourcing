using Core;
using Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using System.Security.Cryptography;
using Web.CustFilter;

namespace Web.Areas.CompanyArea.Controllers
{
    [CompanyAuth]
    [Area("CompanyArea")]
    public class ProjectAssignedController : Controller
    {
        IProjectAssignedRepo repo;
        IProjectRepo prepo;
        EDeskContext ec;

        public ProjectAssignedController(IProjectAssignedRepo repo, IProjectRepo prepo,EDeskContext ec)
        {
            this.repo = repo;
            this.prepo = prepo;
            this.ec = ec;
        }
        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public IActionResult ProjectAssignment(Int64 id)
        {
            ViewBag.SelectedApplicationId = id;
            //var pa = ec.ProjectAssigneds.Where(t => t.SelectedApplicationId == id).Select(p => p.ProjectId).FirstOrDefault();

            var pid = (from sa in ec.SelectedApplications
                       join pa in ec.ProjectApplications on sa.ProjectApplicationId equals pa.ProjectApplicationId
                       where sa.SelectedApplicationId == id
                       select pa.ProjectId).FirstOrDefault();

            ViewBag.ProjectId = pid;
            return View();
        }

        [HttpPost]
        public IActionResult ProjectAssignment(ProjectAssigned rec)
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
