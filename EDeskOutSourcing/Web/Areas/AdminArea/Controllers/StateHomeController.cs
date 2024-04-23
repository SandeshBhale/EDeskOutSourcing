using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class StateHomeController : Controller
    {
        IStateRepo staterepo;
        ICountryRepo countryrepo;

        public StateHomeController(IStateRepo staterepo,ICountryRepo countryrepo)
        {
            this.staterepo = staterepo;
            this.countryrepo = countryrepo;
        }

        public IActionResult Index()
        {
            return View(this.staterepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(State rec)
        {
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            if (ModelState.IsValid)
            {
                this.staterepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            var rec = this.staterepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(State rec)
        {
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            if (ModelState.IsValid)
            {
                this.staterepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.staterepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
