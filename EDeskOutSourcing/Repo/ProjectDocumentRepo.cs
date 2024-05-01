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
    public class ProjectDocumentRepo : GenRepo<ProjectDocument>, IProjectDocumentRepo
    {
        EDeskContext ec;

        public ProjectDocumentRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public List<ProjectDocument> GetAllProjectDocument()
        {
            return this.ec.ProjectDocuments.ToList();
        }
    }
}
