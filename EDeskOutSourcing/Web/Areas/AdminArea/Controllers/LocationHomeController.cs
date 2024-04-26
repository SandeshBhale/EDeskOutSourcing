using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repo;
using Repo.ViewModels;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [AdminAuth]
    [Area("AdminArea")]
    public class LocationHomeController : Controller
    {
        ICountryRepo countryrepo;
        IStateRepo staterepo;
        ICityRepo cityrepo;
        ILocationRepo repo;
        
        public LocationHomeController(ICountryRepo countryrepo, IStateRepo staterepo,ICityRepo cityrepo,ILocationRepo repo)
        {
            this.countryrepo = countryrepo;
            this.staterepo = staterepo;
            this.cityrepo = cityrepo;
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            ViewBag.State = new SelectList(this.staterepo.GetAll(), "StateId", "StateName");
            ViewBag.City = new SelectList(this.cityrepo.GetAll(), "CityId", "CityName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Location rec)
        {
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            ViewBag.State = new SelectList(this.staterepo.GetAll(), "StateId", "StateName");
            ViewBag.City = new SelectList(this.cityrepo.GetAll(), "CityId", "CityName");
            if (ModelState.IsValid)
            {
                this.repo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {

            var rec = this.repo.GetById(id);
            ViewBag.State = new SelectList(this.staterepo.GetAll(), "StateId", "StateName");
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            ViewBag.City = new SelectList(this.cityrepo.GetAll(), "CityId", "CityName");
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(City rec)
        {
            ViewBag.State = new SelectList(this.staterepo.GetAll(), "StateId", "StateName");
            ViewBag.Country = new SelectList(this.countryrepo.GetAll(), "CountryId", "CountryName");
            ViewBag.City = new SelectList(this.cityrepo.GetAll(), "CityId", "CityName");
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

        public IActionResult GetCitiesJson(Int64 id)
        {
            var rec = this.cityrepo.GetCitiesByStatesId(id);
            return Json(rec.ToList());
        }
        
    }
}
