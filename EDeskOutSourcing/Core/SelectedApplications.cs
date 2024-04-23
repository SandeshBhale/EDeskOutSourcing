using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("SelectedApplicationTable")]
    public class SelectedApplications
    {
        [Key]
        public Int64 SelectedApplicationId { get; set; }
        public Int64 ProjectApplicationId { get; set; }
        public virtual ProjectApplications ProjectApplications { get; set; }
        public DateTime SelectionDate { get; set; }
        public DateTime NeedStartDate { get; set; }
        public string AnyRemark { get; set; }
    }
}
