using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class ProjectTechnologiesVC:ViewComponent
    {
        IProjectTechnologyRepo repo;

        public ProjectTechnologiesVC(IProjectTechnologyRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            var rec = repo.GetProjectTechnology();
            return View(rec);
        }
    }
}
