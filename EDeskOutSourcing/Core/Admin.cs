using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core
{
    [Table("AdminTable")]
    public class Admin
    {
        [Key]

        public Int64 AdminId { get; set; }
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
        public string Email { get; set; }
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Number should be 10 digit")]
        public string Mobile { get; set; }
        public string Password { get; set; }

    }
}
