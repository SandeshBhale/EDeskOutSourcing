using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTaskReportReleasePaymentTable")]
    public class ProjectTaskReportReleasePayment
    {
        [Key]
        public Int64 ProjectTaskReportReleasePaymentId { get; set; }
        public Int64 ProjectTaskReportId { get; set; }
        public virtual ProjectTaskReport ProjectTaskReport { get; set; }
        public decimal PaymentAmount { get; set; }
    }
}
