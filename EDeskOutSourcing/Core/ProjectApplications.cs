using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectApplicationsTable")]
    public class ProjectApplications
    {
        [Key]
        public Int64 ProjectApplicationId { get; set; }
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.Now;
        public string ApplicationTitle { get; set; }
        public string ApplicationBody { get; set; }
    }
}
