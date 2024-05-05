using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModels;
using Web.CustFilter;

namespace Web.Areas.AdminHome.Controllers
{
    [CompanyAuth]
    [Area("CompanyArea")]
    public class FreelancerExperienceHomeController : Controller
    {
        ICompany repo;
        ICityRepo crepo;

        public FreelancerExperienceHomeController(ICompany repo, ICityRepo crepo)
        {
            this.repo = repo;
            this.crepo = crepo;
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
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("CompanyId"));
                var res = this.repo.ChangePassword(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }


        [HttpGet]
        public IActionResult EditProfile()
        {
            ViewBag.City = new SelectList(this.crepo.GetAll(), "CityId", "CityName");
            Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("CompanyId"));
            var rec = this.repo.GetById(cid);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditProfile(CompanyProfileVM rec)
        {
            ViewBag.City = new SelectList(this.crepo.GetAll(), "CityId", "CityName");
            if (ModelState.IsValid)
            {
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("CompanyId"));
                var res = this.repo.EditProfile(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
    }
}