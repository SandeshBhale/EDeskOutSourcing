using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TermsAndConditionsForCompany")]
    public class TNCCompany
    {
        [Key]
        public Int64 TNCCompanyId { get; set; }
        public string CompanyRule { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
    }
}
