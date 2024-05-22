using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.CodeAnalysis;
using Repo;
using Repo.ViewModels;
using System.ComponentModel.Design;
using Web.CustFilter;

namespace Web.Areas.CompanyArea.Controllers
{
    [CompanyAuth]
    [Area("CompanyArea")]
    public class SelectedApplicationsController : Controller
    {
        ISelectedApplicationRepo repo;
        public SelectedApplicationsController(ISelectedApplicationRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            Int64 id = Convert.ToInt32(HttpContext.Session.GetString("CompanyId"));
            ViewBag.CompanyId = id;
            return View(this.repo.GetByCompanyId(id));
        }

    }
}