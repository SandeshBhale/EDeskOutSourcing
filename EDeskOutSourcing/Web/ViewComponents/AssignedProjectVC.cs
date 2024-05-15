using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class AssignedProjectVC:ViewComponent
    {
        IProjectAssignedRepo repo;

        public AssignedProjectVC(IProjectAssignedRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            var v = this.repo.GetAllAssignedProjects();
            return View(v.ToList());
        }
    }
}
