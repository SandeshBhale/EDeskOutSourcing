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
    public class SkillCategoryRepo : GenRepo<SkillCategory>, ISkillCategoryRepo
    {
        EDeskContext ec;

        public SkillCategoryRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }
    }
}
