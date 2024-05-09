using Core;
using Infra;
using Microsoft.Identity.Client;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class ProjectStageRepo : GenRepo<ProjectStage>, IProjectStageRepo
    {
        EDeskContext ec;
        ProjectStage ps;
        public ProjectStageRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public void AddRecord(List<ProjectStage> rec)
        {
            foreach (var temp in rec)
            {
                ProjectStage ps = new ProjectStage();
                ps.ProjectStageName = temp.ProjectStageName;
                ps.DurationInHours = temp.DurationInHours;
                ps.StageDescription = temp.StageDescription;
                ps.ProjectId = temp.ProjectId;
                this.ec.ProjectStages.Add(ps);
            }
            this.ec.SaveChanges();
        }
        public List<ProjectStage> GetProject()
        {
            return this.ec.ProjectStages.ToList();
        }

        public void RemoveStage(ProjectStageVM rec)
        {
            var oldstage = this.ec.ProjectStages.ToList().Where(p => p.ProjectId == rec.ProjectId);
            foreach (var temp in oldstage)
            {
                this.ec.ProjectStages.Remove(temp);
            }
            this.ec.SaveChanges();
        }
        public void GetProjectStageId(ProjectStage id)
        {
            var v = this.ps.ProjectStageId;
        }
    }
}
