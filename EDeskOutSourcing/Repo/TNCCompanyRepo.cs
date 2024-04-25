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
    public class TNCCompanyRepo : GenRepo<TNCCompany>, ITNCCompanyRepo
    {
        EDeskContext ec;

        public TNCCompanyRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }
    }
}
