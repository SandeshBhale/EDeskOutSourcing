using Core;
using Infra;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        IProjectRepo prepo;
        IProjectApplicationRepo parepo;

        public HomeController(IProjectRepo prepo,IProjectApplicationRepo parepo)
        {
            this.prepo = prepo;
            this.parepo = parepo;
        }
        public IActionResult Index()
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
            return View();
        }

        public IActionResult List()
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
            return View();
        }

        [HttpGet]
        public IActionResult ProjectSearch(Int64 skill, Int64 tech, Int64 term)
        {
            var r = this.prepo.SearchByProperty(skill, tech, term);

            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;
           
            ViewBag.rec = r;
            return View("Index", new {id=r});
        }

        [HttpGet]
        public IActionResult SubmitApplication(Int64 id)
        {
            int freelancerId = Convert.ToInt32(HttpContext.Session.GetString("FreelancerId"));
            ViewBag.FreelancerId = freelancerId;

            ViewBag.ProjectId = id;
            var rec = from t in this.prepo.GetAll()
                      where t.ProjectId == id
                      select t.ProjectName;
            ViewBag.ProjectName = rec;

            return View();
        }

        [HttpPost]
        public IActionResult SubmitApplication(ProjectApplications rec)
        {
            if (ModelState.IsValid)
            {
                if (rec.FreelancerId != 0)
                {
                    this.parepo.Add(rec);
                    ViewBag.Message = "Application Sent Successfully";
                    return RedirectToAction("Index");
                }
            }
            
            return RedirectToAction("SignIn","ManageFreelancer");
        }
    }
}
