using Core;
using Infra;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
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

            var sk = from p in this.ec.ProjectSkill
                     join p1 in this.ec.Skill
                     on p.SkillId equals skill
                     join p2 in this.ec.Projects
                     on p.ProjectId equals p2.ProjectId
                     select p2.ProjectId;

            var tr = from tc in this.ec.Projects
                    where tc.ProjectPaymentTerms == term
                    select tc.ProjectId;

            var te = from pt in this.ec.ProjectTechnology
                     join pt1 in this.ec.Technologies
                     on pt.TechnologiesId equals tech
                     join pt2 in this.ec.Projects
                     on pt.ProjectId equals pt2.ProjectId
                     select pt2.ProjectId;

            var commonProjectIds = sk.Intersect(tr).Intersect(te);

            var projects = from p in this.ec.Projects
                           where commonProjectIds.Contains(p.ProjectId)
                           select p;
                    
            return projects.ToList();
        }
    }
}
