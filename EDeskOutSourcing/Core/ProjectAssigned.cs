using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectAssignedTable")]
    public class ProjectAssigned
    {
        [Key]
        public Int64 ProjectAssignedId { get; set; }
        public Int64 SelectedApplicationId { get; set; }
        public virtual SelectedApplications SelectedApplications { get; set; }
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string ApplicationTitle { get; set; }
    }
}
