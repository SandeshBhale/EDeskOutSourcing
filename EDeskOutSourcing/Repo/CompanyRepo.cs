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
    public class CompanyRepo : ICompany
    {
        EDeskContext ec;

        public CompanyRepo(EDeskContext ec)
        {
            this.ec = ec;
        }

        public LoginResultVM Login(LoginVM rec)
        {
            LoginResultVM res = new LoginResultVM();
            var urec = this.ec.Companies.SingleOrDefault(p => p.EmailId == rec.Email && p.Password == rec.Password);

            if (urec != null)
            {
                res.IsSucess = true;
                res.LoggedInId = urec.CompanyId;
                res.LoggedInName = urec.CompanyName;
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
            var oldrec = this.ec.Companies.Find(id);
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

        public RepoResultVM EditProfile(CompanyProfileVM rec, long id)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                var oldrec = this.ec.Companies.Find(id);
                oldrec.CompanyName = rec.CompanyName;
                oldrec.Address = rec.Address;
                oldrec.EmailId = rec.EmailId;
                oldrec.MobileNo = rec.Mobile;
                oldrec.ContactPersonName = rec.ContactPersonName;
                oldrec.CityId = rec.CityId;
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

        public CompanyProfileVM GetById(long id)
        {
            var rec = (from t in this.ec.Companies
                       where t.CompanyId == id
                       select new CompanyProfileVM
                       {
                           CompanyName = t.CompanyName,
                           Address = t.Address,
                           EmailId = t.EmailId,
                           Mobile = t.MobileNo,
                           ContactPersonName = t.ContactPersonName,
                           CityId = t.CityId,
                       }).FirstOrDefault();
            return rec;
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }

        public RepoResultVM AddCompanyRec(CompanySignUpVM rec)
        {
            RepoResultVM res = new RepoResultVM();
            try
            {
                Company Comp = new Company();
                Comp.CompanyName = rec.CompanyName;
                Comp.ContactPersonName = rec.ContactPersonName;
                Comp.Address = rec.Address;
                Comp.MobileNo = rec.MobileNo;
                Comp.EmailId = rec.EmailId;
                Comp.Password = rec.Password;
                Comp.CityId = rec.CityId;
                this.ec.Companies.Add(Comp);
                this.ec.SaveChanges();
                res.IsSucess = true;
                res.Message = "Sign Up SucessFull!";
            }
            catch (Exception ex)
            {
                res.IsSucess = false;
                res.Message = ex.Message.ToString();
            }
            return res;
        }

        public List<CityVM> GetCitiesByStatesId(long stateId)
        {
            var v = from t in this.ec.Cities
                    where t.StateId == stateId
                    select new CityVM
                    {
                        CityId = t.CityId,
                        CityName = t.CityName,
                    };
            return v.ToList();
        }

        public List<StateVM> GetStatesByCountryId(long countryId)
        {
            var v = from t in this.ec.States
                    where t.CountryId == countryId
                    select new StateVM
                    {
                        StateId = t.StateId,
                        StateName = t.StateName,
                    };
            return v.ToList();
        }
    }
}
