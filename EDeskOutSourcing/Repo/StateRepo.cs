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
    public class StateRepo : GenRepo<State>,IStateRepo
    {
        EDeskContext ec;
        
        public StateRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public List<StateVM> GetStatesByCountryId(long CountryId)
        {
            var v = from t in this.ec.States
                    where t.CountryId == CountryId
                    select new StateVM
                    {
                        StateId = t.StateId,
                        StateName = t.StateName,
                    };
            return v.ToList();
        }
    }
}
