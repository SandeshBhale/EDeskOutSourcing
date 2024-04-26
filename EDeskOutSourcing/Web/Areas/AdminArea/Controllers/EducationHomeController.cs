using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.Enums;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [AdminAuth]
    [Area("AdminArea")]
    public class EducationHomeController : Controller
    {

        IEducationRepo repo;

        public EducationHomeController(IEducationRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Education rec)
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
            var rec = this.repo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Education rec)
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
