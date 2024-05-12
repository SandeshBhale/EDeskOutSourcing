using Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repo;

namespace Web.ViewComponents
{
    public class LayoutDropdownVC : ViewComponent
    {
        IProjectSkillRepo psrepo;
        IProjectTechnologyRepo ptrepo;
        ISkillRepo srepo;
        ITechnologiesRepo trepo;

        public LayoutDropdownVC(IProjectSkillRepo psrepo,IProjectTechnologyRepo ptrepo,ISkillRepo srepo,ITechnologiesRepo trepo)
        {
            this.srepo = srepo;
            this.trepo = trepo;
            this.psrepo = psrepo;
            this.ptrepo = ptrepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            var ProjectSkills = this.psrepo.GetAll().Select(s => new
            {
                SkillId = s.SkillId,
                SkillName = s.Skill.SkillName,
                ProjectId = s.ProjectId
            }).ToList();

            var ProjectTechnologies = this.ptrepo.GetAll().Select(s => new
            {
                TechnologiesId = s.TechnologiesId,
                TechnologyName = s.Technologies.TechnologyName,
                ProjectId = s.ProjectId
            }).ToList();


            ViewBag.ProjectSkillId = new SelectList(ProjectSkills, "SkillId", "SkillName");
             
            ViewBag.ProjectTechnologyId = new SelectList(ProjectTechnologies, "TechnologiesId", "TechnologyName");
            return View();
        }
    }
}
