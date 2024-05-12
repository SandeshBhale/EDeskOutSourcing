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
        IProjectApplicationRepo parepo;

        public HomeController(IProjectRepo prepo,EDeskContext ec,IProjectApplicationRepo parepo)
        {
            this.prepo = prepo;
            this.ec = ec;
            this.parepo = parepo;
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
            var r = this.prepo.SearchByProperty1(skill, tech, term);
            foreach (var temp in r)
            { 
                skill = temp;
                tech= temp;
                term = temp;
            }

            var rec = this.prepo.SearchByProperty(skill, tech, term);
           
            ViewBag.rec = rec;
            return View("Index");
        }

        [HttpGet]
        public IActionResult SubmitApplication(Int64 id)
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
            ViewBag.ProjectId = id;
            return View();
        }

        [HttpPost]
        public IActionResult SubmitApplication(ProjectApplications rec)
        {
            if (ModelState.IsValid)
            {
                this.parepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }
    }
}
