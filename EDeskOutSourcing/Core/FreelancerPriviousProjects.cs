using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("FreelancerPriviousProjectsTable")]
    public class FreelancerPriviousProjects
    {
        [Key]
        public Int64 FreelancerPriviousProjectsId { get; set; }
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
    }
}
