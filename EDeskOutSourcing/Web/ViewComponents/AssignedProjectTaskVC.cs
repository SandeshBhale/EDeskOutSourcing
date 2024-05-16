using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class AssignedProjectTaskVC:ViewComponent
    {
        IProjectTaskAssignmentRepo repo;

        public AssignedProjectTaskVC(IProjectTaskAssignmentRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            var v = this.repo.GetAllAssignedProjectTasks();
            return View(v.ToList());
        }
    }
}
