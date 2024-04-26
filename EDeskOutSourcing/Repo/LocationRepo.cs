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
    }
}
