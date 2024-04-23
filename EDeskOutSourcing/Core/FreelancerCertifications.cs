using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("FreelancerCertificationTable")]
    public class FreelancerCertifications
    {
        [Key]
        public Int64 FreelancerCertificationId { get; set; }
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }
        public string CertificateTitle { get; set; }
        public string PassingYear { get; set; }
        public string UnivercityInstituteName { get; set; }
    }
}
