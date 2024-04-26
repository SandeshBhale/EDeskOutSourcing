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
    public class CityRepo : GenRepo<City>,ICityRepo
    {
        EDeskContext ec;

        public CityRepo(EDeskContext ec): base(ec)
        {
            this.ec = ec;
        }

        public List<CityVM> GetCitiesByStatesId(long StatesId)
        {
            var v = from t in this.ec.Cities
                    where t.StateId == StatesId
                    select new CityVM
                    {
                        CityId = t.CityId,
                        CityName = t.CityName,
                    };
            return v.ToList();
        }
    }
}
