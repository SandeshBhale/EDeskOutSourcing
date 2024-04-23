using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("FinishedProjectTable")]
    public class FinishedProject
    {
        [Key]
        public Int64 FinishedProjectId { get; set; }
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public DateTime FinishedDate { get; set; }
        public string FinishedRemark { get; set; }
    }
}
