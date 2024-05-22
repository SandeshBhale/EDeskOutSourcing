using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModels;

namespace Web.Controllers
{
    public class ManageCompanyController : Controller
    {
        ICompany repo;
        ICountryRepo countryrepo;
        IStateRepo staterepo;
        ICityRepo cityrepo;

        public ManageCompanyController(ICompany repo, ICountryRepo countryrepo, IStateRepo staterepo, ICityRepo cityrepo)
        {
            this.repo = repo;
            this.countryrepo = countryrepo;
            this.staterepo = staterepo;
            this.cityrepo = cityrepo;
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
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            ViewBag.State = new SelectList(this.staterepo.GetAll(), "StateId", "StateName");
            ViewBag.City = new SelectList(this.cityrepo.GetAll(), "CityId", "CityName");
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(CompanySignUpVM rec)
        {
            if (ModelState.IsValid)
            {
               this.repo.AddCompanyRec(rec);
               return RedirectToAction("SignIn");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }

        public IActionResult GetStatesJson(Int64 id)
        {
            var rec = this.repo.GetStatesByCountryId(id);
            return Json(rec.ToList());
        }

        public IActionResult GetCitiesJson(Int64 id)
        {
            var rec = this.repo.GetCitiesByStatesId(id);
            return Json(rec.ToList());
        }
    }
}
