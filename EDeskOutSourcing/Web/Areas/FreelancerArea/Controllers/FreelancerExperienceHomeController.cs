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
    public class FreelancerExperienceHomeController : Controller
    {

        IFreelancerExperienceRepo repo;
        IFreelancerRepo frepo;

        public FreelancerExperienceHomeController(IFreelancerExperienceRepo repo, IFreelancerRepo frepo)
        {
            this.repo = repo;
            this.frepo = frepo;
        }

        public IActionResult Index()
        {
            int id = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            return View(this.repo.GetAllByFreelancerId(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(FreelancerExperienceVM rec)
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
            if (ModelState.IsValid)
            {
                for (int i = 0; i < rec.FreelancerExperiences.CompanyName.Count(); i++)
                {
                    FreelancerExperience fexp = new FreelancerExperience();
                    fexp.CompanyName = rec.FreelancerExperiences.CompanyName[i];
                    fexp.ExperienceInMonths = rec.FreelancerExperiences.ExperienceInMonths[i];
                    fexp.FromDate = rec.FreelancerExperiences.FromDate[i];
                    fexp.ToDate = rec.FreelancerExperiences.ToDate[i];
                    fexp.RoleName = rec.FreelancerExperiences.RoleName[i];
                    fexp.FreelancerId = rec.FreelancerId;

                    if (fexp.ToDate <= fexp.FromDate)
                    {
                        ModelState.AddModelError("", "To Date must be greater than From Date.");
                        return View(rec);
                    }

                    this.repo.Add(fexp);
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
            ViewBag.FreelancerExperienceId = id;
            var rec = this.repo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(FreelancerExperience rec)
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
            if (ModelState.IsValid)
            {
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
