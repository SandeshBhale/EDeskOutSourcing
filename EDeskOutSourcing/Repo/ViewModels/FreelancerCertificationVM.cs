using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class FreelancerCertificationVM
    {
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }
        public string CertificateTitle { get; set; }
        public string PassingYear { get; set; }
        public string UnivercityInstituteName { get; set; }
        public virtual FreelancerCertificationsVM FreelancerCertifications { get; set; }
    }
}
