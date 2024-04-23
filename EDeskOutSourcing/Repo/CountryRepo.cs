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
    public class CountryRepo : GenRepo<Country>,ICountryRepo
    {
        EDeskContext ec;

        public CountryRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public List<CountryVM> GetCountryById(long countryid)
        {
            //  return this.cc.Subject.Where(p => p.SubjectStreamID == streamid).ToList();
            var v = from t in this.ec.Countries
                    where t.CountryId == countryid
                    select new CountryVM
                    {
                        CountryId = t.CountryId,
                        CountryName = t.CountryName
                    };

            return v.ToList();

        }
    }
}
