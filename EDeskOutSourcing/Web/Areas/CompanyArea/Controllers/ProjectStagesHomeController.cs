using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModels;
using System.ComponentModel.Design;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [CompanyAuth]
    [Area("CompanyArea")]
    public class ProjectStagesHomeController : Controller
    {
        IProjectStagesRepo repo;
        IProjectRepo prepo;
        public ProjectStagesHomeController(IProjectStagesRepo repo,IProjectRepo prepo)
        {
            this.prepo = prepo;
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(int ProjectId, ProjectStagesVM rec)
        {
            ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            //if (ModelState.IsValid)
            //{
            //    return RedirectToAction("Index");
            //}
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
        public IActionResult Edit(ProjectStages rec)
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

        public JsonResult InsertProjectStages([FromBody] List<ProjectStagesVM> ProjectStages)
        {
            this.repo.AddRecord(ProjectStages);
            return Json(ProjectStages);
        }
    }
}