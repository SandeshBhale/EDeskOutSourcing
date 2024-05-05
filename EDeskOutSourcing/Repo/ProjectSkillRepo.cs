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
    }
}
