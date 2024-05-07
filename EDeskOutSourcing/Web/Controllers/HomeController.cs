using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        IProjectRepo prepo;

        public HomeController(IProjectRepo prepo)
        {
            this.prepo = prepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        [HttpGet]
        public IActionResult searchByProperty(Int64 skill, Int64 tech, Int64 term)
        {
            //var rec = this.prepo.SearchByProperty(skill, tech,term);
            //ViewBag.rec = rec;
            //  return View("List", rec);
            return View  ("rec");
        }
    }
}
