using Core;
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

        public IViewComponentResult Invoke(List<ProjectStage> id)
        {
            //var rec = repo.GetProjectStageId( id);
            return View(id.ToList());
        }
    }
}
