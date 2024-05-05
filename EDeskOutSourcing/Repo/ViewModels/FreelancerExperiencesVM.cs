using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class FreelancerExperiencesVM
    {
        public List<string> CompanyName { get; set; }
        public List<int> ExperienceInMonths { get; set; }
        public List<DateTime> FromDate { get; set; } 
        public List<DateTime> ToDate { get; set;}
        public List<string> RoleName { get; set; }
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }

        public FreelancerExperiencesVM()
        {
            CompanyName = new List<string>();
            ExperienceInMonths = new List<int>();
            FromDate = new List<DateTime>();
            ToDate = new List<DateTime>();
            RoleName = new List<string>();
            Freelancer = new Freelancer();
        }
    }
}
