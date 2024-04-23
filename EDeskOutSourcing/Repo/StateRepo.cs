using Core;
using Infra;
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
    }
}
