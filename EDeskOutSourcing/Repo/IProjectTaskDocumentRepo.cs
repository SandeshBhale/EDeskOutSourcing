using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IProjectTaskDocumentRepo : IGenRepo<ProjectTaskDocument>
    {
        List<ProjectTaskDocument> GetAllProjectTaskDocument();

        List<ProjectTaskDocument> GetProjectTaskDocumentById(Int64 id);
    }
}
