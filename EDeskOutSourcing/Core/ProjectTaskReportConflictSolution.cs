using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTaskReportConflictSolutionTable")]
    public class ProjectTaskReportConflictSolution
    {
        [Key]
        public Int64 ProjectTaskReportConflictSolutionId { get; set; }
        public Int64 ProjectTaskReportConflictId {  get; set; }
        public virtual ProjectTaskReportConflict ProjectTaskReportConflict { get; set; }
        public DateTime SolutionDate { get; set; }
        public string SolutionDescription { get; set; }
    }
}
