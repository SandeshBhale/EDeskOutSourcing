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
    public class ProjectStagesRepo : GenRepo<ProjectStages>, IProjectStagesRepo
    {
        EDeskContext ec;
        public ProjectStagesRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public void AddRecord(List<ProjectStagesVM> rec)
        {
            foreach(var temp in rec)
            {
                ProjectStages ps = new ProjectStages();
                ps.ProjectStageName = temp.ProjectStageName;
                ps.DurationInHours = temp.DurationInHours;
                ps.StageDescription = temp.StageDescription;
                ps.ProjectId = temp.ProjectId;
                this.ec.ProjectStages.Add(ps);
            }
            this.ec.SaveChanges();
        }
    }
}
