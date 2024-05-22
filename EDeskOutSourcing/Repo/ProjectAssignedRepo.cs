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

        public List<ProjectAssigned> GetAllAssignedProjects(long id)
        {
            var v = from t in this.ec.ProjectAssigneds
                    join t1 in this.ec.SelectedApplications
                    on t.SelectedApplicationId equals t1.SelectedApplicationId
                    join t2 in this.ec.ProjectApplications
                    on t1.ProjectApplicationId equals t2.ProjectApplicationId
                    where t2.Project.CompanyId==id
                    select t;
            return v.ToList();
        }

        public List<ProjectAssigned> GetByCompanyId(long id)
        {
            return this.ec.ProjectAssigneds.Where(p=>p.Project.CompanyId == id).ToList();
        }
    }
}
