using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class CompanyProfileVM
    {
        [Required(ErrorMessage ="Comapny Name Required")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage ="Company Address Required")]
        public string Address { get; set; }
        [Required(ErrorMessage ="EmailId Required")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Mobile No Required")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Number should be 10 digit")]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Contact Person Name Required")]
        public string ContactPersonName { get; set; }
        [Required(ErrorMessage ="City Name Required")]
        public Int64 CityId { get; set; }
    }
}
