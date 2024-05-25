using Core;
using Infra;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class ProjectSkillRepo : GenRepo<ProjectSkill>, IProjectSkillRepo
    {
        EDeskContext ec;

        public ProjectSkillRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public void AddRec(ProjectVM rec)
        {
            foreach (var temp in rec.ProjSkills)
            {
                bool exists = this.ec.ProjectSkill
                                  .Any(ps => ps.ProjectId == rec.ProjectId && ps.SkillId == temp);

                if (!exists)
                {
                    ProjectSkill p = new ProjectSkill();
                    p.ProjectId = rec.ProjectId;
                    p.SkillId = temp;
                    this.ec.ProjectSkill.Add(p);
                }
            }
            this.ec.SaveChanges();
        }


        public void AddRecTech(ProjectVM rec)
        {
            foreach (var temp in rec.ProjTechnologies)
            {
                bool exists = this.ec.ProjectTechnology
                                  .Any(pt => pt.ProjectId == rec.ProjectId && pt.TechnologiesId == temp);

                if (!exists)
                {
                    ProjectTechnology p = new ProjectTechnology();
                    p.ProjectId = rec.ProjectId;
                    p.TechnologiesId = temp;
                    this.ec.ProjectTechnology.Add(p);
                }
            }
            this.ec.SaveChanges();
        }


        public List<ProjectSkill> GetProjectSkills()
        {
            return this.ec.ProjectSkill.ToList();
        }
    }
}
