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

        public IViewComponentResult Invoke(Int64 id)
        {
            var v = this.repo.GetAllNotAssignedProjects(id);
            return View(v.ToList());
        }
    }
}
