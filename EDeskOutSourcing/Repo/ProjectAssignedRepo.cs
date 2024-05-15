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
    public class ProjectAssignedRepo : GenRepo<ProjectAssigned>, IProjectAssignedRepo
    {
        EDeskContext ec;

        public ProjectAssignedRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public List<ProjectAssigned> GetAllAssignedProjects()
        {
            var v = from t in this.ec.ProjectAssigneds
                    join t1 in this.ec.SelectedApplications
                    on t.SelectedApplicationId equals t1.SelectedApplicationId
                    select t;
            return v.ToList();
        }
    }
}
