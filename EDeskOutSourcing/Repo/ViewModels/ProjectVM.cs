using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class ProjectVM
    {
        public Int64 ProjectId { get; set; }
        public List<Int64> ProjSkills {  get; set; }
        public List<Int64> ProjTechnologies { get; set; }
        public ProjectVM()
        {
            ProjSkills = new List<Int64>();
            ProjTechnologies = new List<Int64>();
        }
    }
}
