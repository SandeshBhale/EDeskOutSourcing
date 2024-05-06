using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class ProjectStagesVC:ViewComponent
    {
        IProjectStageRepo repo;

        public ProjectStagesVC(IProjectStageRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            var rec = repo.GetProject();
            return View(rec);
        }
    }
}
