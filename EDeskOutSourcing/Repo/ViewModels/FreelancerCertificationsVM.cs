using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class FreelancerCertificationsVM
    {
        public List<string> CertificateTitle { get; set; }
        public List<string> PassingYear { get; set; }
        public List<string> UnivercityInstituteName { get; set; }
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }

        public FreelancerCertificationsVM()
        {
            CertificateTitle = new List<string>();
            PassingYear = new List<string>();
            UnivercityInstituteName = new List<string>();
            Freelancer = new Freelancer();
        }
    }
}
