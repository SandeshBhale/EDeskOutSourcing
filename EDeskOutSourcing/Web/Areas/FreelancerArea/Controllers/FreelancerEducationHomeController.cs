using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repo;
using Repo.ViewModels;
using System.ComponentModel.Design;
using Web.CustFilter;

namespace Web.Areas.FreelancerArea.Controllers
{
    [FreelancerAuth]
    [Area("FreelancerArea")]
    public class FreelancerEducationHomeController : Controller
    {

        IFreelancerEducationRepo repo;
        IFreelancerRepo frepo;
        IEducationRepo erepo;

        public FreelancerEducationHomeController(IFreelancerEducationRepo repo, IFreelancerRepo frepo, IEducationRepo erepo)
        {
            this.repo = repo;
            this.frepo = frepo;
            this.erepo = erepo;
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
            ViewBag.EducationId = new SelectList(this.erepo.GetAll(), "EducationId", "EducationName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(FreelancerEducationVM rec)
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
            ViewBag.EducationId = new SelectList(this.erepo.GetAll(), "EducationId", "EducationName");
            if (ModelState.IsValid)
            {
                for (int i = 0; i < rec.FreelancerEducations.EducationId.Count(); i++)
                {
                    FreelancerEducation fexp = new FreelancerEducation();
                    fexp.EducationId = rec.FreelancerEducations.EducationId[i];
                    fexp.PassingYear = rec.FreelancerEducations.PassingYear[i];
                    fexp.UnivercityInstituteName = rec.FreelancerEducations.UnivercityInstituteName[i];
                    fexp.FreelancerId = rec.FreelancerId;
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
            ViewBag.EducationId = id;
            var rec = this.repo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(FreelancerEducation rec)
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
            ViewBag.EducationId = new SelectList(this.erepo.GetAll(), "EducationId", "EducationName",rec.EducationId);
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
