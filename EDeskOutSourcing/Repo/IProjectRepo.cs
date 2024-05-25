using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IProjectRepo : IGenRepo<Project>
    {
        List<Project> GetAllProject();
        List<Project> SearchByProperty(Int64 skill=0, Int64 tech=0,Int64 term=0);
        List<Project> SearchByProperty1(Int64 skill = 0, Int64 tech = 0, Int64 term = 0);
        List<ProjectStage> GetProjectStageById(Int64 id);
        List<ProjectSkill> GetProjectSkillById(Int64 id);
        List<ProjectTechnology> GetProjectTechnologyById(Int64 id);
        List<Project> GetByCompanyId(Int64 id);

    }
}
