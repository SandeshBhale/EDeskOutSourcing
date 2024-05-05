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
    public class FreelancerCertificationsRepo : GenRepo<FreelancerCertifications>, IFreelancerCertificationsRepo
    {
        EDeskContext ec;

        public FreelancerCertificationsRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }
    }
}
