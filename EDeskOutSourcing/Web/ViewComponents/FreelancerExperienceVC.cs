using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class FreelancerExperienceVC:ViewComponent
    {
        IFreelancerExperienceRepo repo;

        public FreelancerExperienceVC(IFreelancerExperienceRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke(List<FreelancerExperience> id)
        {
            //var rec = repo.GetProjectSkills();
            return View(id.ToList());
        }
    }
}
