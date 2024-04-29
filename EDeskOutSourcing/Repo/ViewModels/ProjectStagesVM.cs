using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class ProjectStagesVM
    {
        public string ProjectStageName { get; set; }
        public double DurationInHours { get; set; }
        public string StageDescription { get; set; }

        [ForeignKey("Project")]
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
