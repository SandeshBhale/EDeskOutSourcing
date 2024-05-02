using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModels;

namespace Web.Controllers
{
    public class ManageFreelancerController : Controller
    {
        IFreelancerRepo repo;

        public ManageFreelancerController(IFreelancerRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.repo.Login(rec);
                if (res.IsSucess)
                {
                    HttpContext.Session.SetString("FreelancerId", res.LoggedInId.ToString());
                    HttpContext.Session.SetString("FullName", res.LoggedInName);
                    return RedirectToAction("Index", "FreelancerHome", new { area = "FreelancerArea" });
                }
                else
                {
                    ModelState.AddModelError("", res.ErrorMessage);
                    return View(rec);
                }
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpVM rec)
        {
            if (ModelState.IsValid)
            {
                this.repo.AddFreelancerRec(rec);
                return RedirectToAction("SignIn");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }

    }
}
