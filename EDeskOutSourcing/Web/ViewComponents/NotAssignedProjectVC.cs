using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class NotAssignedProjectVC:ViewComponent
    {
        ISelectedApplicationRepo repo;

        public NotAssignedProjectVC(ISelectedApplicationRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            var v = this.repo.GetAllNotAssignedProjects();
            return View(v.ToList());
        }
    }
}
