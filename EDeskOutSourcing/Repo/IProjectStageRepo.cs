using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IProjectStageRepo : IGenRepo<ProjectStage>
    {
        void AddRecord(List<ProjectStage> rec);
        List<ProjectStage> GetProject();
        void GetProjectStageId(ProjectStage id);
        void RemoveStage(ProjectStageVM rec);
        List<ProjectStage> GetByCompanyId(Int64 Id);
    }
}
