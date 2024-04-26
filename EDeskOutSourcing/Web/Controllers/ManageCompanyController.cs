using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModels;

namespace Web.Controllers
{
    public class ManageCompanyController : Controller
    {
        ICompany repo;

        public ManageCompanyController(ICompany repo)
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
                    HttpContext.Session.SetString("CompanyId", res.LoggedInId.ToString());
                    HttpContext.Session.SetString("CompanyName", res.LoggedInName);
                    return RedirectToAction("Index", "CompanyHome", new { area = "CompanyArea" });
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
                
                return RedirectToAction("Index");
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
