using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class FreelancerPrviousProjectVM
    {
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public virtual FreelancerPriviousProjectsVM FreelancerPriviousProjects { get; set; }
    }
}
