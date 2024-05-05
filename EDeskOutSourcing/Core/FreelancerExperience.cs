using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("FreelancerExperienceTable")]
    public class FreelancerExperience
    {
        [Key]
        public Int64 FreelancerExperienceId { get; set; }
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }
        public int ExperienceInMonths { get; set; }
        public string CompanyName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string RoleName { get; set; }

    }
}
