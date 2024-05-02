using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class FreelancerProfileVM
    {
        [Required(ErrorMessage="FirstName Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage="LastName Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Email Id Required")]
        public string EmailId { get; set; }
        [Required(ErrorMessage ="Mobile No Required")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Number should be 10 digit")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage ="Address Is Required")]        
        public string Address { get; set; }
    }
}
    