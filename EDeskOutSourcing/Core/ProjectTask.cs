using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTaskTable")]
    public class ProjectTask
    {
        [Key]
        public Int64 ProjectTaskId { get; set; }
        public string TaskTitle { get; set; }
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public string TaskDescription { get; set; }
        public decimal TaskAmount { get; set; }
    }
}
