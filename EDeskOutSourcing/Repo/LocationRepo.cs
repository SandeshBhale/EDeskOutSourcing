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
    public class LocationRepo : GenRepo<Location>,ILocationRepo
    {
        EDeskContext ec;
        public LocationRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
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
