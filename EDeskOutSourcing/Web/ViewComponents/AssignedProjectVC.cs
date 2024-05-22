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

        public IViewComponentResult Invoke(Int64 id)
        {
            var v = this.repo.GetAllAssignedProjects(id);
            return View(v.ToList());
        }
    }
}
