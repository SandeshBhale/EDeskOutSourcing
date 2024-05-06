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
    public class ProjectTechnologyRepo : GenRepo<ProjectTechnology>, IProjectTechnologyRepo
    {
        EDeskContext ec;

        public ProjectTechnologyRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public List<ProjectTechnology> GetProjectTechnology()
        {
            return this.ec.ProjectTechnology.ToList();
        }
    }
}
