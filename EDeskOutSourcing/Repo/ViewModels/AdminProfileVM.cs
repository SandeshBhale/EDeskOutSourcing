using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class AdminProfileVM
    {
        [Required(ErrorMessage="FirstName Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage="LastName Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Email Id Required")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Mobile No Required")]
        public string Mobile { get; set; }
        
    }
}
