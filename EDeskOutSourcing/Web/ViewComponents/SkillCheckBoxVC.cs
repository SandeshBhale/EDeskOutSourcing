using Core;
using Infra;
using Microsoft.AspNetCore.Mvc;
using Repo;
using Repo.ViewModels;
using System.Linq;

namespace Web.ViewComponents
{
    public class SkillCheckBoxVC:ViewComponent
    {
        EDeskContext repo;

        public SkillCheckBoxVC(EDeskContext repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke(Int64 id = 0)
        {
            if (id == 0)
            {
                var v = from t in this.repo.Skill.ToList()
                        select new CheckBoxVM
                        {
                            CheckBoxID = t.SkillId,
                            CheckBoxText = t.SkillName,
                            IsSelected = false
                        };
                return View(v.ToList());
            }
            else
            {
                var oldskill = this.repo.Skill.ToList().Where(c => c.SkillId == id);
                var v = from t in this.repo.Skill.ToList()
                        select new CheckBoxVM
                        {
                            CheckBoxID = t.SkillId,
                            CheckBoxText = t.SkillName,
                            IsSelected = false
                        };
                return View(v.ToList());
            }
        }

    }
}
