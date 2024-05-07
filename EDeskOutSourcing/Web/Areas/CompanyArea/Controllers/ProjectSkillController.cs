using Infra.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repo;
using Repo.ViewModels;
using Web.CustFilter;

namespace Web.Areas.CompanyArea.Controllers
{
    [CompanyAuth]
    [Area("CompanyArea")]
    public class ProjectSkillController : Controller
    {
        IProjectSkillRepo repo;
        IProjectRepo prepo;

        public ProjectSkillController(IProjectSkillRepo repo, IProjectRepo prepo)
        {
            this.repo = repo;
            this.prepo = prepo;
        }
        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public IActionResult Create(Int64 id)
        {
            ViewBag.ProjectId = id;
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProjectVM rec)
        {
            if (ModelState.IsValid)
            {
                this.repo.AddRec(rec);
            }
            return RedirectToAction("Index","ProjectHome");
        }
    }
}
