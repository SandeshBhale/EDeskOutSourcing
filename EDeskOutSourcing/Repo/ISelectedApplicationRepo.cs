using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface ISelectedApplicationRepo : IGenRepo<SelectedApplications>
    {
        List<SelectedApplications> GetAllNotAssignedProjects(Int64 id);
        List<SelectedApplications> GetByCompanyId(Int64 id);
    }
}
