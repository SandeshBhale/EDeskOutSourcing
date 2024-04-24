using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IAdmin
    {
        LoginResultVM Login(LoginVM rec);
        RepoResultVM ChangePassword(ChangePasswordVM rec, Int64 id);
        RepoResultVM EditProfile(AdminProfileVM rec, Int64 id);
        AdminProfileVM GetById(Int64 id);
    }
}
