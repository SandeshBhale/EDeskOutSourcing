using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTaskReportTable")]
    public class ProjectTaskReport
    {
        [Key]
        public Int64 ProjectTaskReportId { get; set; }
        public Int64 ProjectTaskAssignmentId { get; set; }
        public virtual ProjectTaskAssignment ProjectTaskAssignment { get; set; }
        public Int64 ProjectTaskId { get; set; }
        public virtual ProjectTask ProjectTask { get; set; }
        public string SourceFilePath { get; set; }
        public bool IsReviewed { get; set; }
    }
}
