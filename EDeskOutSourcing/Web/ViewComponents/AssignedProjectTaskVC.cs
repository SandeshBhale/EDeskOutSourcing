using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class AssignedProjectTaskVC:ViewComponent
    {
        IProjectTaskRepo repo;

        public AssignedProjectTaskVC(IProjectTaskRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            var v = this.repo.GetAllNotAssignedProjectTasks();
            return View(v.ToList());
        }
    }
}
