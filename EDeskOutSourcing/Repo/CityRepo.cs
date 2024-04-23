using Core;
using Infra;
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
    }
}
