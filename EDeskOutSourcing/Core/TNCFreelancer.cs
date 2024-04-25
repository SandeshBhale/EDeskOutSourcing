using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TermsAndConditionsForFreelancer")]
    public class TNCFreelancer
    {
        [Key]
        public Int64 TNCFreelancerId { get; set; }
        public string FreelancerRule { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
    }
}
