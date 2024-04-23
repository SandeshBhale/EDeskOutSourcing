using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TerminatedProjectTable")]
    public class TerminatedProject
    {
        [Key]
        public Int64 TerminatedProjectId { get; set; }
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public DateTime TerminationDate { get; set; }
        public string TerminationRemark { get; set; }
    }
}
