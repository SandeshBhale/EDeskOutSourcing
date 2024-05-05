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
        
    }
}
