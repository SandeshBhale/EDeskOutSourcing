using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("EducationTable")]
    public class Education
    {
        [Key]
        public Int64 EducationId { get; set; }
        public string EducationName { get; set; }
        public int EducationType { get; set; }
    }
}
