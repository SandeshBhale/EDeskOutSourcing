using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class NotAssignedProjectTaskVC: ViewComponent
    {
        IProjectTaskRepo repo;

        public NotAssignedProjectTaskVC(IProjectTaskRepo repo)
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
