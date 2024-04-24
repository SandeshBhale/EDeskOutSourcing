using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [AdminAuth]
    [Area("AdminArea")]
    public class CityHomeController : Controller
    {
        ICountryRepo countryrepo;
        IStateRepo staterepo;
        ICityRepo cityrepo;
        
        public CityHomeController(ICountryRepo countryrepo, IStateRepo staterepo,ICityRepo cityrepo)
        {
            this.countryrepo = countryrepo;
            this.staterepo = staterepo;
            this.cityrepo = cityrepo;
        }
        public IActionResult Index()
        {
            return View(this.cityrepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            ViewBag.State = new SelectList(this.staterepo.GetAll(), "StateId", "StateName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(City rec)
        {
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            ViewBag.State = new SelectList(this.staterepo.GetAll(), "StateId", "StateName");
            if (ModelState.IsValid)
            {
                this.cityrepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.State = new SelectList(this.staterepo.GetAll(), "StateId", "StateName");
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            var rec = this.cityrepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(City rec)
        {
            ViewBag.State = new SelectList(this.staterepo.GetAll(), "StateId", "StateName");
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            if (ModelState.IsValid)
            {
                this.cityrepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.cityrepo.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult GetStatesJson(Int64 id)
        {
            var rec = this.staterepo.GetStatesByCountryId(id);
            return Json(rec.ToList());
        }
    }
}
