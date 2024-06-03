using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.CodeAnalysis;
using Repo;
using Repo.ViewModels;
using System.ComponentModel.Design;
using Web.CustFilter;

namespace Web.Areas.CompanyArea.Controllers
{
    [CompanyAuth]
    [Area("CompanyArea")]
    public class ProjectStageHomeController : Controller
    {
        IProjectStageRepo repo;
        IProjectRepo prepo;
        public ProjectStageHomeController(IProjectStageRepo repo,IProjectRepo prepo)
        {
            this.prepo = prepo;
            this.repo = repo;
        }

        public IActionResult Index()
        {
            int id = Convert.ToInt32(HttpContext.Session.GetString("CompanyId"));
            return View(this.repo.GetByCompanyId(id));
        }


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            return View();
        }


        [HttpPost]
        public IActionResult Create(ProjectStageVM rec)

        {
            ViewBag.ProjectId = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            if (ModelState.IsValid)
            {
                ProjectStage prec = new ProjectStage();
                //prec.ProjectId = rec.ProjectId;

                for (int i = 0; i < rec.ProjectStageName.Count(); i++)
                {
                    ProjectStage ptemp = new ProjectStage();
                    //ptemp.ProjectStageId = rec.ProjectStageId[i];
                    ptemp.StageDescription = rec.StageDescription[i];
                    ptemp.ProjectStageName = rec.ProjectStageName[i];
                    ptemp.DurationInHours = rec.DurationInHours[i];
                    ptemp.ProjectId = rec.ProjectId;
                    prec.ProjectStages.Add(ptemp);
                }

                this.repo.AddRecord(prec.ProjectStages);
                return RedirectToAction("Index");
            }

            return View(rec);
        }

        [HttpGet]
        public ActionResult StageList(Int64 id)
        {
            return View(this.repo.GetAllById(id));
        }


        [HttpGet]
        public ActionResult Edit(Int64 id,Int64 id2)
        {
            ViewBag.ProjectId = id2;
            var rec = this.repo.GetById(id);
            return View(rec);
        }


        [HttpPost]
        public IActionResult Edit(ProjectStage rec)
        {
            var id2 = rec.ProjectId;
            if (ModelState.IsValid)
            {
                this.repo.Edit(rec);
                return RedirectToAction("StageList", new { id = id2 });
            }
            return View();
        }



        [HttpGet]
        public IActionResult Delete(Int64 id,Int64 id2)
        {
            this.repo.Delete(id);
            return RedirectToAction("StageList", new {id=id2});
        }
    }
}