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
                // Create a new instance of ProjectSkill for each record
                ProjectSkill p = new ProjectSkill();

                // Assign values
                p.ProjectId = rec.ProjectId;
                p.SkillId = temp;

                // Add to context and then to DbSet
                this.ec.ProjectSkill.Add(p);
            }

            // Save changes after adding all records
            this.ec.SaveChanges();
        }

        public void AddRecTech(ProjectVM rec)
        {

            foreach (var temp in rec.ProjTechnologies)
            {
                ProjectTechnology p = new ProjectTechnology();
                p.ProjectId = rec.ProjectId;
                p.TechnologiesId = temp;
                this.ec.ProjectTechnology.Add(p);
            }
            this.ec.SaveChanges();
        }

        public List<ProjectSkill> GetProjectSkills()
        {
            return this.ec.ProjectSkill.ToList();
        }
    }
}
