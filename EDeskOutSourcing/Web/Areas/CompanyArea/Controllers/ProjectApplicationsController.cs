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
    public class ProjectApplicationsController : Controller
    {
        IProjectApplicationRepo repo;
        IFreelancerRepo frepo;
        IProjectRepo prepo;
        ISelectedApplicationRepo srepo;
        public ProjectApplicationsController(IProjectApplicationRepo repo,IProjectRepo prepo,IFreelancerRepo frepo,ISelectedApplicationRepo srepo)
        {
            this.prepo = prepo;
            this.repo = repo;
            this.frepo = frepo;
            this.srepo = srepo;
        }

        public IActionResult Index()
        {
            int id = Convert.ToInt32(HttpContext.Session.GetString("CompanyId"));
            return View(this.repo.GetByCompanyId(id));
        }

        public IActionResult ViewAndAssign(Int64 id)
        {
            return View(this.repo.GetAllByFreelancerId(id));
        }

        public IActionResult ViewProfile(Int64 id1,Int64 id)
        {
            ViewBag.ProjectApplicationId = id1;

            var fExp = this.repo.GetFreelancerExperienceById(id);
            ViewBag.FreelancerExperience = fExp;

            var fEdu = this.repo.GetFreelancerEducationById(id);
            ViewBag.FreelancerEducation = fEdu;

            var fProj = this.repo.GetFreelancerPriviousProjectsById(id);
            ViewBag.FreelancerPriviousProjects = fProj;

            var fCerti = this.repo.GetFreelancerCertificationsById(id);
            ViewBag.FreelancerCertifications = fCerti;

            var rec = this.frepo.GetById(id);
            return View(rec);
        }

        [HttpGet]
        public IActionResult SelectedApplication(Int64 id)
        {
            ViewBag.ProjectApplicationId = id;
            return View();
        }

        [HttpPost]
        public IActionResult SelectedApplication(SelectedApplications rec)
        {
            if (ModelState.IsValid)
            {
                this.srepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

    }
}