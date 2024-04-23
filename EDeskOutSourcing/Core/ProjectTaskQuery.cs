using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTaskQueryTable")]
    public class ProjectTaskQuery
    {
        [Key]
        public Int64 ProjectTaskQueryId { get; set; }
        public string QueryTitle { get; set; }
        public Int64 ProjectTaskId { get; set; }
        public virtual ProjectTask ProjectTask { get; set; }
        public string QueryDescription { get; set; }
        public bool IsSolved { get; set; }
    }
}
