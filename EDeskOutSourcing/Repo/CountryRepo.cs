using Core;
using Infra;
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
    }
}
