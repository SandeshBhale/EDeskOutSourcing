using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Web.Areas.CompanyArea.Controllers;

namespace Web.ViewComponents
{
    public class ProjectTechnologiesVC:ViewComponent
    {
        IProjectTechnologyRepo repo;

        public ProjectTechnologiesVC(IProjectTechnologyRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke(List<ProjectTechnology> id)
        {
            //var rec = repo.GetProjectTechnology();
            return View(id.ToList());
        }
    }
}
