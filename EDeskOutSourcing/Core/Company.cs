using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("CompanyTable")]
    public class Company
    {
        [Key]
        public Int64 CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        [RegularExpression("^[0-9]{10}$",ErrorMessage ="Number should be 10 digit")]
        public string MobileNo { get; set; }
        public string ContactPersonName { get; set; }
        public Int64 CityId { get; set; }
        public virtual City City { get; set; }
        public DateTime JoinedDate { get; set; }
        public string Password { get; set; }
    }
}
