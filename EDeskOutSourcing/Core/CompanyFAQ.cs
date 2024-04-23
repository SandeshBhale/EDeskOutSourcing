using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CompanyFAQTable")]
    public class CompanyFAQ
    {
        [Key]
        public Int64 CompanyFAQId { get; set; }
        public string FAQ { get; set; }
        public string Answer { get; set; }
        public DateTime AddedDate { get; set; }
    }
}