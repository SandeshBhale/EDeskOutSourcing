using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectStagesTable")]
    public class ProjectStage
    {
        [Key]
        public Int64 ProjectStageId { get; set; }
        public string ProjectStageName { get; set; }
        [ForeignKey("ProjectId")]
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public int DurationInHours { get; set; }
        public string StageDescription { get; set; }

        public virtual List<ProjectStage> ProjectStages { get; set; }
        public ProjectStage()
        {
            ProjectStages = new List<ProjectStage>();
        }
    }
}
