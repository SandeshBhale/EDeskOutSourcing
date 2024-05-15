using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IProjectTaskRepo : IGenRepo<ProjectTask>
    {
        List<ProjectTask> GetAllNotAssignedProjectTasks();
        List<ProjectTask> GetAllAssignedProjectTasks();
    }
}
