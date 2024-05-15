using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class SelectedApplicationVM
    {
        public Int64 SelectedApplicationId { get; set; }
        public Int64 ProjectId { get; set; }
        public virtual SelectedApplications SelectedApplications { get; set; }
        public virtual Project Project { get; set; }
    }
}
