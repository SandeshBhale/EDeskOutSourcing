using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTaskReportReleasePaymentConflictSolutionTable")]
    public class ProjectTaskReportReleasePaymentConflictSolution
    {
        [Key]
        public Int64 ProjectTaskReportReleasePaymentConflictSolutionId { get; set; }
        public Int64 ProjectTaskReportReleasePaymentConflictId { get; set; }
        public virtual ProjectTaskReportReleasePaymentConflict GetProjectTaskReportReleasePaymentConflict { get; set; }

        public DateTime SolutionDate { get; set; }
        public string SolutionDescription { get; set; }

    }
}
