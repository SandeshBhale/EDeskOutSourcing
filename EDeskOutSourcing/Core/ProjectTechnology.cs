using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTechnology")]
    public class ProjectTechnology
    {
        [Key]
        public Int64 ProjectTechnologyId { get; set; }
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public Int64 TechnologiesId { get; set; }
        public virtual Technologies Technologies { get; set;}
        [NotMapped]
        public string ProjectTechnologyName { get; set; }
    }
}
