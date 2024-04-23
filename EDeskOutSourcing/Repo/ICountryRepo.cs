using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface ICountryRepo : IGenRepo<Country>
    {
        List<CountryVM> GetCountryById(Int64 CountryId);
    }
}
