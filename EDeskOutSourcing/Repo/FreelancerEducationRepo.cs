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
    public class FreelancerEducationRepo : GenRepo<FreelancerEducation>, IFreelancerEducationRepo
    {
        EDeskContext ec;

        public FreelancerEducationRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public List<FreelancerEducation> GetAllByFreelancerId(long id)
        {
            return this.ec.FreelancerEducations.Where(p=>p.FreelancerId == id).ToList();
        }
    }
}
