using Core;
using Infra;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        EDeskContext ec;
        IProjectRepo prepo;

        public HomeController(IProjectRepo prepo,EDeskContext ec)
        {
            this.prepo = prepo;
            this.ec = ec;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProjectSearch(Int64 skill, Int64 tech, Int64 term)
        {
            var rec = this.prepo.SearchByProperty(skill, tech, term);
            ViewBag.rec = rec;
            return View("Index");
        }

        [HttpGet]
        public IActionResult SubmitApplication(Int64 id)
        {
           return View();
        }

        [HttpPost]
        public IActionResult SubmitApplication(ProjectApplications rec)
        {
            return View(rec);
        }
    }
}
