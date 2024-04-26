using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class CityVM
    {
        public Int64 CityId { get; set; }
        public string CityName { get; set; }
        public Int64 StateId { get; set; }
        public Int64 CountryId { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }
    }
}
