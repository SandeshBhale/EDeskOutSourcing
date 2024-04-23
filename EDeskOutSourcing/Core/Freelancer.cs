using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("FreelancerTable")]
    public class Freelancer
    {
        [Key]
        public Int64 FreelancerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string EmailId { get; set; }
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Number should be 10 digit")]
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
    }
}
