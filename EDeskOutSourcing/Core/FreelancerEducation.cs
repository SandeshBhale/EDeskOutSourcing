using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("FreelancerEducationTable")]
    public class FreelancerEducation
    {
        [Key]
        public Int64 FreelancerEducationId { get; set; }
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }
        public Int64 EducationId { get; set; }
        public virtual Education Education { get; set; }
        public string PassingYear { get; set; }
        public string UnivercityInstituteName { get; set; }
    }
}
