using Core;
using Infra;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class FreelancerPriviousProjectsRepo : GenRepo<FreelancerPriviousProjects>, IFreelancerPriviousProjectsRepo
    {
        EDeskContext ec;

        public FreelancerPriviousProjectsRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }
    }
}
