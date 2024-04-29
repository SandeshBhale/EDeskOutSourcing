using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class MainProjectStagesVM
    {
        public string ProjectStageName { get; set; }
        public double DurationInHours { get; set; }
        public string StageDescription { get; set; }
        public List<ProjectStagesVM> ProjectStages { get; set; }
    }
}
