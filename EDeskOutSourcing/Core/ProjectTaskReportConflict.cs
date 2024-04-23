using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTaskReportConflictTable")]
    public class ProjectTaskReportConflict
    {
        [Key]
        public Int64 ProjectTaskReportConflictId { get; set; }
        public Int64 ProjectTaskReportId { get; set; }
        public virtual ProjectTaskReport ProjectTaskReport { get; set; }
        public DateTime ConflictDate { get; set; }
        public string ConflictRemark { get; set; }
    }
}
