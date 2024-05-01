using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using System.ComponentModel.Design;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [CompanyAuth]
    [Area("CompanyArea")]
    public class ProjectDocumentHomeController : Controller
    {

        IProjectDocumentRepo repo;

        public ProjectDocumentHomeController(IProjectDocumentRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            int companyId = Convert.ToInt32(HttpContext.Session.GetString("CompanyId"));
            ViewBag.CompanyId = companyId;
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
        public IActionResult Create(ProjectDocument rec)
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
        public IActionResult Edit(ProjectDocument rec)
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
