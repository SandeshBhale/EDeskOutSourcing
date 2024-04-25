using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTable")]
    public class Project
    {
        [Key]
        public Int64 ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public Int64 CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public int ProjectStatus { get; set; }
        public int ProjectPaymentTerms{ get; set; }
        public string ProjectTermsAndConditions { get; set; }
        public decimal Budget { get; set; }
        public decimal ExpectedCompletionDurationInDays { get; set; }
    }
}
