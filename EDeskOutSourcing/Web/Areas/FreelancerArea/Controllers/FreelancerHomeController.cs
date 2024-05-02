using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModels;
using Web.CustFilter;

namespace Web.Areas.FreelancerHome.Controllers
{
    [FreelancerAuth]
    [Area("FreelancerArea")]
    public class FreelancerHomeController : Controller
    {
        IFreelancerRepo repo;

        public FreelancerHomeController(IFreelancerRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("FreelancerId"));
                var res = this.repo.ChangePassword(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }


        [HttpGet]
        public IActionResult EditProfile()
        {
            Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("FreelancerId"));
            var rec = this.repo.GetById(cid);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditProfile(FreelancerProfileVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("FreelancerId"));
                var res = this.repo.EditProfile(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
    }
}