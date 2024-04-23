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
    public class ProjectStages
    {
        [Key]
        public Int64 ProjectStageId { get; set; }
        public string ProjectStageName { get; set; }
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public decimal DurationInHours { get; set; }
        public string StageDescription { get; set; }
    }
}
