using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class FreelancerExperienceVM
    {
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }
        public int ExperienceInMonths { get; set; }
        public string CompanyName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string RoleName { get; set; }
        public virtual FreelancerExperiencesVM FreelancerExperiences { get; set; }
    }
}
