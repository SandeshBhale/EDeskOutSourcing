using Core;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class FreelancerCertificationsVC:ViewComponent
    {
        IFreelancerCertificationsRepo repo;

        public FreelancerCertificationsVC(IFreelancerCertificationsRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke(List<FreelancerCertifications> id)
        {
            //var rec = repo.GetProjectSkills();
            return View(id.ToList());
        }
    }
}
