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

        public IViewComponentResult Invoke(Int64 id)
        {
            var v = this.repo.GetAllNotAssignedProjectTasks(id);
            return View(v.ToList());
        }
    }
}
