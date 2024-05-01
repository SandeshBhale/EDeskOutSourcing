using Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class ProjectStageVM
    {
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public List<string> ProjectStageName { get; set; }
        public List<int> DurationInHours { get; set; }
        public List<string> StageDescription { get; set; }

        public ProjectStageVM()
        {
           // ProjectStageId = new List<Int64>();
            ProjectStageName = new List<string>();
            DurationInHours = new List<int>();
            StageDescription = new List<string>();
        }
    }
}
