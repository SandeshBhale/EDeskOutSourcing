using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class CountryHomeController : Controller
    {

        ICountryRepo countryrepo;

        public CountryHomeController(ICountryRepo countryrepo)
        {
            this.countryrepo = countryrepo;
        }

        //Below Code For Country

        public IActionResult Index()
        {
            return View(this.countryrepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country rec)
        {
            if (ModelState.IsValid)
            {
                this.countryrepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.countryrepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Country rec)
        {
            if (ModelState.IsValid)
            {
                this.countryrepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.countryrepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}