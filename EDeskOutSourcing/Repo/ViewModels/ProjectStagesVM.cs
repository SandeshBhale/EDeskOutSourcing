using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class ProjectStagesVM
    {
        public List<ProjectStages> ProjectStages {  get; set; }

        public List<Project> Projects { get; set; }
        public string ProjectStageName { get; set; }
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public decimal DurationInHours { get; set; }
        public string StageDescription { get; set; }
    }
}
