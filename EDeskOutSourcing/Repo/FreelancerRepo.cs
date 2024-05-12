using Core;
using Infra;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class FreelancerRepo : GenRepo<Freelancer>, IFreelancerRepo
    {
        EDeskContext ec;

        public FreelancerRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var urec = this.ec.Freelancers.SingleOrDefault(p => p.EmailId == rec.Email && p.Password == rec.Password);

            if (urec != null)
            {
                res.IsSucess = true;
                res.LoggedInId = urec.FreelancerId;
                res.LoggedInName = urec.FullName;
            }
            else
            {
                res.IsSucess = false;
                res.ErrorMessage = "Invalid EmailId or Password !";
            }
            return res;
        }

        public RepoResultVM ChangePassword(ChangePasswordVM rec, Int64 id)
        {
            RepoResultVM res = new RepoResultVM();
            //find old record
            var oldrec = this.ec.Freelancers.Find(id);
            if (oldrec.Password == rec.OldPassword)
            {
                oldrec.Password = rec.NewPassword;
                this.ec.SaveChanges();
                res.IsSucess = true;
                res.Message = "Password Changed Successfully!";
            }
            else
            {
                res.IsSucess = false;
                res.Message = "Invalid Old Password!";
            }

            return res;
        }

        public RepoResultVM EditProfile(FreelancerProfileVM rec, long id)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var oldrec = this.ec.Freelancers.Find(id);
                oldrec.FirstName = rec.FirstName;
                oldrec.LastName = rec.LastName;
                oldrec.Address = rec.Address;
                oldrec.EmailId = rec.EmailId;
                oldrec.MobileNo = rec.MobileNo;
                oldrec.Address = rec.Address;
                this.ec.SaveChanges();
                res.IsSucess = true;
                res.Message = "Profile Updated!";
            }
            catch (Exception ex)
            {
                res.IsSucess = false;
                res.Message = ex.Message.ToString();
            }

            return res;
        }

        public FreelancerProfileVM GetById(long id)
        {
            var rec = (from t in this.ec.Freelancers
                       where t.FreelancerId == id
                       select new FreelancerProfileVM
                       {
                           FirstName = t.FirstName,
                           LastName = t.LastName,
                           Address = t.Address,
                           EmailId = t.EmailId,
                           MobileNo = t.MobileNo
                       }).FirstOrDefault();
            return rec;
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }

        public RepoResultVM AddFreelancerRec(SignUpVM rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                Freelancer freelancer = new Freelancer();
                freelancer.FirstName = rec.FirstName;
                freelancer.LastName = rec.LastName;
                freelancer.EmailId = rec.EmailId;
                freelancer.Password = rec.Password;
                this.ec.Freelancers.Add(freelancer);
                this.ec.SaveChanges();
                res.IsSucess = true;
                res.Message = "Sign Up SucessFull!";
            }
            catch(Exception ex)
            {
                res.IsSucess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }
    }
}
