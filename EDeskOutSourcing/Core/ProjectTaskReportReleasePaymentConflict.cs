using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTaskReportReleasePaymentConflictTable")]
    public class ProjectTaskReportReleasePaymentConflict
    {
        [Key]
        public Int64 ProjectTaskReportReleasePaymentConflictId { get; set; }
        public Int64 ProjectTaskReportId { get; set; }
        public virtual ProjectTaskReport ProjectTaskReport { get; set; }
        public decimal PaymentAmount { get; set; }
    }
}
