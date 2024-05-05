using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [AdminAuth]
    [Area("AdminArea")]
    public class SkillHomeController : Controller
    {
        ISkillRepo repo;
        ISkillCategoryRepo srepo;

        public SkillHomeController(ISkillRepo repo,ISkillCategoryRepo srepo)
        {
            this.repo = repo;
            this.srepo = srepo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.SkillCategoryId = new SelectList(this.srepo.GetAll(), "SkillCategoryId", "SkillCategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Skill rec)
        {
            ViewBag.SkillCategoryId = new SelectList(this.srepo.GetAll(), "SkillCategoryId", "SkillCategoryName");
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
            ViewBag.SkillCategoryId = new SelectList(this.srepo.GetAll(), "SkillCategoryId", "SkillCategoryName");
            var rec = this.repo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Skill rec)
        {
            ViewBag.SkillCategoryId = new SelectList(this.srepo.GetAll(), "SkillCategoryId", "SkillCategoryName",rec.SkillCategoryId);
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
