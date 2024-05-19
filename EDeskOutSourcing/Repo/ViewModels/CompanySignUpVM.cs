using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class CompanySignUpVM
    {
        [Required(ErrorMessage = "Last Name Required")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage ="Contact Person Name Required")]
        public string ContactPersonName { get; set; }
        [Required(ErrorMessage = "EmailId Required")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Mobile Number Required")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Number should be 10 digit")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage ="City Name Required")]
        public Int64 CityId { get; set; }
        public virtual City City { get; set; }
        [Required(ErrorMessage ="Address Required")]
        public string Address { get; set; }

        public Int64 StateId { get; set; }
        public virtual State State { get; set; }

        public Int64 CountryId { get; set; }
        public virtual Country Country { get; set; }

    }
}
