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
    public class ProjectTaskRepo : GenRepo<ProjectTask>, IProjectTaskRepo
    {
        EDeskContext ec;

        public ProjectTaskRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public List<ProjectTask> GetAllNotAssignedProjectTasks(long id)
        {
            var V = from t in this.ec.ProjectTasks
                    where t.Project.CompanyId==id && 
                    !(from t1 in this.ec.ProjectTaskAssignments
                           select t1.ProjectTaskId).Contains(t.ProjectTaskId)
                    select t;
            return V.ToList();
        }

        public List<ProjectTask> GetByCompanyId(long id)
        {
            return this.ec.ProjectTasks.Where(p => p.Project.CompanyId == id).ToList();
        }
    }
}
