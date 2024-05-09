using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using System.ComponentModel.Design;
using Web.CustFilter;

namespace Web.Areas.CompanyArea.Controllers
{
    [CompanyAuth]
    [Area("CompanyArea")]
    public class ProjectHomeController : Controller
    {

        IProjectRepo repo;

        public ProjectHomeController(IProjectRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            int companyId = Convert.ToInt32(HttpContext.Session.GetString("CompanyId"));
            ViewBag.CompanyId = companyId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project rec)
        {
            if (ModelState.IsValid)
            {
                this.repo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            int companyId = Convert.ToInt32(HttpContext.Session.GetString("CompanyId"));
            ViewBag.CompanyId = companyId;
            var rec = this.repo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Project rec)
        {
            if (ModelState.IsValid)
            {
                this.repo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.repo.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var pStage = this.repo.GetProjectStageById(id);
            ViewBag.ProjectStage = pStage;

            var pSkill = this.repo.GetProjectSkillById(id);
            ViewBag.ProjectSkill = pSkill;

            var pTech = this.repo.GetProjectTechnologyById(id);
            ViewBag.ProjectTechnology = pTech;

            var rec =this.repo.GetById(id);
            return View(rec);
        }
    }
}
