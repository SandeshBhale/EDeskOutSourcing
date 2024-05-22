using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class StateVM
    {
        public Int64 StateId { get; set; }
        public string StateName { get; set; }
        public Int64 CountryId { get; set; }
        public virtual Country Country { get; set; }
    }   
}
