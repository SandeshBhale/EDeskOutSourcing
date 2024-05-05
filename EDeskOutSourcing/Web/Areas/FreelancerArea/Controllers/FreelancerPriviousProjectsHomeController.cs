using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModels;
using System.ComponentModel.Design;
using Web.CustFilter;

namespace Web.Areas.FreelancerArea.Controllers
{
    [FreelancerAuth]
    [Area("FreelancerArea")]
    public class FreelancerPriviousProjectsHomeController : Controller
    {

        IFreelancerPriviousProjectsRepo repo;
        IFreelancerRepo frepo;

        public FreelancerPriviousProjectsHomeController(IFreelancerPriviousProjectsRepo repo, IFreelancerRepo frepo)
        {
            this.repo = repo;
            this.frepo = frepo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(FreelancerPrviousProjectVM rec)
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
            if (ModelState.IsValid)
            {
                for (int i = 0; i < rec.FreelancerPriviousProjects.ProjectTitle.Count(); i++)
                {
                    FreelancerPriviousProjects fpp = new FreelancerPriviousProjects();
                    fpp.ProjectTitle = rec.FreelancerPriviousProjects.ProjectTitle[i];
                    fpp.ProjectDescription = rec.FreelancerPriviousProjects.ProjectDescription[i];
                    fpp.FreelancerId = rec.FreelancerId;
                    this.repo.Add(fpp);
                }
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
            ViewBag.FreelancerPriviousProjectsId = id;
            var rec = this.repo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(FreelancerPriviousProjects rec)
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
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
