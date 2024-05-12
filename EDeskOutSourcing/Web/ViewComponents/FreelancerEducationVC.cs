using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class FreelancerEducationVC:ViewComponent
    {
        IFreelancerEducationRepo repo;

        public FreelancerEducationVC(IFreelancerEducationRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke(List<FreelancerEducation> id)
        {
            //var rec = repo.GetProjectSkills();
            return View(id.ToList());
        }
    }
}
