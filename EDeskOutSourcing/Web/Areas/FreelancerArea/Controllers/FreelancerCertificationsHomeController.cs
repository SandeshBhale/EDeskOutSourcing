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
    public class FreelancerCertificationsHomeController : Controller
    {

        IFreelancerCertificationsRepo repo;
        IFreelancerRepo frepo;

        public FreelancerCertificationsHomeController(IFreelancerCertificationsRepo repo, IFreelancerRepo frepo)
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
        public IActionResult Create(FreelancerCertificationVM rec)
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
            if (ModelState.IsValid)
            {
                for (int i = 0; i < rec.FreelancerCertifications.CertificateTitle.Count(); i++)
                {
                    FreelancerCertifications fc = new FreelancerCertifications();
                    fc.CertificateTitle = rec.FreelancerCertifications.CertificateTitle[i];
                    fc.PassingYear = rec.FreelancerCertifications.PassingYear[i];
                    fc.UnivercityInstituteName = rec.FreelancerCertifications.UnivercityInstituteName[i];
                    fc.FreelancerId = rec.FreelancerId;

                    this.repo.Add(fc);
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
            ViewBag.FreelancerCertificationId = id;
            var rec = this.repo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(FreelancerCertifications rec)
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
