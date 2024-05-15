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
    public class ProjectTaskDocumentRepo : GenRepo<ProjectTaskDocument>, IProjectTaskDocumentRepo
    {
        EDeskContext ec;

        public ProjectTaskDocumentRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public List<ProjectTaskDocument> GetAllProjectTaskDocument()
        {
            return this.ec.ProjectTaskDocuments.ToList();
        }

        public List<ProjectTaskDocument> GetProjectTaskDocumentById(Int64 id)
        {
            return ec.ProjectTaskDocuments.Where(p => p.ProjectTaskId == id).ToList();
        }
    }
}
