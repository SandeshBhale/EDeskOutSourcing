using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class SignUpVM
    {
        [Required(ErrorMessage ="Name Required")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage ="EmailId Required")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password Required")]
        [Compare("Password", ErrorMessage = "New Password and Confirm Password are not Same!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
