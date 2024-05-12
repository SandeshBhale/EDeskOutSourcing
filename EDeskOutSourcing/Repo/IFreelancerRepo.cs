using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IFreelancerRepo : IGenRepo<Freelancer>
    {
        LoginResultVM Login(LoginVM rec);
        RepoResultVM ChangePassword(ChangePasswordVM rec, Int64 id);
        RepoResultVM EditProfile(FreelancerProfileVM rec, Int64 id);
        FreelancerProfileVM GetById(Int64 id);
        RepoResultVM AddFreelancerRec(SignUpVM rec);
    }
}
