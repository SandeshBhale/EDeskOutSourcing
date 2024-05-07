using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IProjectRepo : IGenRepo<Project>
    {
       // List<Project> SearchByProperty(Int64 skill=0, Int64 tech=0,Int64 term=0);
    }
}
