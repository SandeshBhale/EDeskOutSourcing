using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IProjectDocumentRepo : IGenRepo<ProjectDocument>
    {
        List<ProjectDocument> GetAllProjectDocument();

        List<ProjectDocument> GetProjectDocumentById(Int64 id);

    }
}
