using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModels;

namespace Web.Controllers
{
    public class ManageAdminController : Controller
    {
        IAdmin repo;

        public ManageAdminController(IAdmin repo)
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
                if(res.IsSucess)
                {
                    HttpContext.Session.SetString("AdminId",res.LoggedInId.ToString());
                    HttpContext.Session.SetString("AdminName", res.LoggedInName);
                    return RedirectToAction("Index", "AdminHome", new { area = "AdminArea" });
                }
                else
                {
                    ModelState.AddModelError("",res.ErrorMessage);
                    return View(rec);
                }
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
