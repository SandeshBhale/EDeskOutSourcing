using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class FreelancerPriviousProjectsVM
    {
        public List<string> ProjectTitle { get; set; }
        public List<string> ProjectDescription { get; set; }
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }

        public FreelancerPriviousProjectsVM()
        {
            ProjectTitle = new List<string>();
            ProjectDescription = new List<string>();
            Freelancer = new Freelancer();
        }
    }
}
