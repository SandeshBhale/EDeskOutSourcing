using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IProjectSkillRepo : IGenRepo<ProjectSkill>
    {
        void AddRec(ProjectVM rec);

        void AddRecTech(ProjectVM rec);

        List<ProjectSkill> GetProjectSkills();
    }
}
