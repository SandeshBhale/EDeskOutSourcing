using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.ProjectModel;
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

        public ProjectStagesHomeController(IProjectStagesRepo repo, IProjectRepo prepo)
        {
            this.repo = repo;
            this.prepo = prepo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }


        [HttpGet]
        public IActionResult Create()
        {
            //var viewModel = new ProjectStagesVM
            //{
            //    ProjectStages = new List<ProjectStages>() 
            //};
            ViewBag.Project = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            //return View(viewModel);
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProjectStagesVM viewModel)
        {
            if (ModelState.IsValid)
            {
                foreach (var stage in viewModel.ProjectStages)
                {
                    this.repo.Add(stage);
                }
                return RedirectToAction("Index");
            }
            ViewBag.Project = new SelectList(this.prepo.GetAll(), "ProjectId", "ProjectName");
            return View(viewModel); // Pass the ViewModel back to the view in case of validation errors
        }


        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
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
    }
}
