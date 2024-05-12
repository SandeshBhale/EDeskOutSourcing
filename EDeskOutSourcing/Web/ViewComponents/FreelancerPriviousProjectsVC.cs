using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class FreelancerPriviousProjectsVC:ViewComponent
    {
        IFreelancerPriviousProjectsRepo repo;

        public FreelancerPriviousProjectsVC(IFreelancerPriviousProjectsRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke(List<FreelancerPriviousProjects> id)
        {
            //var rec = repo.GetProjectSkills();
            return View(id.ToList());
        }
    }
}
