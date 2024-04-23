using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTaskQuerySolutionTable")]
    public class ProjectTaskQuerySolution
    {
        [Key]
        public Int64 ProjectTaskQuerySolutionId { get; set; }
        public string SolutionTitle { get; set; }
        public Int64 ProjectTaskQueryId { get; set; }
        public virtual ProjectTaskQuery ProjectTaskQuery { get; set; }
        public string SolutionDescription { get; set; }
    }
}
