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
    public class ProjectRepo : GenRepo<Project>, IProjectRepo
    {
        EDeskContext ec;

        public ProjectRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public List<Project> GetAllProject()
        {
            return this.ec.Projects.ToList();
        }

        public List<Project> GetByCompanyId(long id)
        {
            return this.ec.Projects.Where(p=>p.CompanyId == id).ToList();
        }

        public List<ProjectSkill> GetProjectSkillById(long id)
        {
            return ec.ProjectSkill.Where(p => p.ProjectId == id).ToList();
        }

        public List<ProjectStage> GetProjectStageById(long id)
        {
            return ec.ProjectStages.Where(p => p.ProjectId == id).ToList();
        }

        public List<ProjectTechnology> GetProjectTechnologyById(long id)
        {
            return ec.ProjectTechnology.Where(p => p.ProjectId == id).ToList();
        }

        public List<Project> SearchByProperty(long skill = 0, long tech = 0, long term = 0)
        {
            //var v =this.ec.ProjectSkill.Select(p => p.ProjectId).ToList();

            var sk = from s in this.ec.ProjectSkill
                    where s.ProjectSkillId == skill
                    select s.ProjectId;

            var tr = from tc in this.ec.Projects
                    where tc.ProjectPaymentTerms == term
                    select tc.ProjectId;

            var te = from ta in this.ec.ProjectTechnology
                     where ta.ProjectTechnologyId == tech
                     select ta.ProjectId;

            // Find common project IDs that match all three criteria
            var commonProjectIds = sk.Intersect(tr).Intersect(te);

            // Retrieve the list of projects that match the common project IDs
            var projects = from p in this.ec.Projects
                           where commonProjectIds.Contains(p.ProjectId)
                           select p;
                    
            return projects.ToList();
        }
    }
}
