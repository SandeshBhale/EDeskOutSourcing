using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.Areas.AdminArea.Controllers
{
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
    }
}
