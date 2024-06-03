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
        IProjectTaskRepo ptrepo;
        IFreelancerRepo frepo;
        IProjectApplicationRepo papprepo;
        IProjectAssignedRepo passrepo;
        ISelectedApplicationRepo sapprepo;
        public ProjectTaskAssignmentController(IProjectTaskAssignmentRepo repo, IProjectRepo prepo,IProjectTaskRepo ptrepo, IFreelancerRepo frepo, IProjectApplicationRepo papprepo,IProjectAssignedRepo passrepo,ISelectedApplicationRepo sapprepo)
        {
            this.repo = repo;
            this.prepo = prepo;
            this.ptrepo = ptrepo;
            this.frepo = frepo;
            this.papprepo = papprepo;
            this.passrepo = passrepo;
            this.sapprepo = sapprepo;
        }
        public IActionResult Index()
        {
            Int64 id = Convert.ToInt32(HttpContext.Session.GetString("CompanyId"));
            ViewBag.CompanyId = id;
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public IActionResult ProjectTaskAssignment(Int64 id)
        {
            ViewBag.ProjectTaskId = id;
            var freelancerId = (from pt in this.ptrepo.GetAll()
                                join passgn in this.passrepo.GetAll() on pt.ProjectId equals passgn.ProjectId
                                join sa in this.sapprepo.GetAll() on passgn.SelectedApplicationId equals sa.SelectedApplicationId
                                join pa in this.papprepo.GetAll() on sa.ProjectApplicationId equals pa.ProjectApplicationId
                                where pt.ProjectTaskId == id
                                select new
                                {
                                    FreelancerId = pa.FreelancerId,
                                    FullName = pa.Freelancer.FullName,
                                }).ToList();

            //ViewBag.FreelancerId = freelancerId;

            ViewBag.FreelancerId = new SelectList(freelancerId, "FreelancerId", "FullName");
            return View();
        }

        [HttpPost]
        public IActionResult ProjectTaskAssignment(ProjectTaskAssignment rec)
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
