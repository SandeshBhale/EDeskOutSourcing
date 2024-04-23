using Infra;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class AdminRepo : IAdmin
    {

        EDeskContext ec;

        public AdminRepo( EDeskContext ec)
        {
            this.ec = ec;
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var urec = this.ec.Admins.SingleOrDefault(p=>p.Email==rec.Email && p.Password==rec.Password);
            
            if(urec != null)
            {
                res.IsSucess = true;
                res.LoggedInId = urec.AdminId;
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
            var oldrec = this.ec.Admins.Find(id);
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

        public RepoResultVM EditProfile(AdminProfileVM rec, long id)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var oldrec = this.ec.Admins.Find(id);
                oldrec.FirstName = rec.FirstName;
                oldrec.LastName = rec.LastName;
                oldrec.Email = rec.Email;
                oldrec.Mobile = rec.Mobile;
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

        public AdminProfileVM GetById(long id)
        {
            var rec = (from t in this.ec.Admins
                       where t.AdminId == id
                       select new AdminProfileVM
                       {
                           FirstName = t.FirstName,
                           LastName = t.LastName,
                           Email = t.Email,
                           Mobile = t.Mobile,
                       }).FirstOrDefault();
            return rec;
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }
    }
}
