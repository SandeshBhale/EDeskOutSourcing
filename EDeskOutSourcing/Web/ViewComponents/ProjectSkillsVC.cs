using Microsoft.AspNetCore.Mvc;
using Repo;

namespace Web.ViewComponents
{
    public class ProjectSkillsVC:ViewComponent
    {
        IProjectSkillRepo repo;

        public ProjectSkillsVC(IProjectSkillRepo repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            var rec = repo.GetProjectSkills();
            return View(rec);
        }
    }
}
