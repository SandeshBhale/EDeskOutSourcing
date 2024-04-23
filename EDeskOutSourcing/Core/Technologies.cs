using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("TechnologiesTable")]
    public class Technologies
    {
        [Key]
        public Int64 TechnologiesId { get; set; }
        public string TechnologyName { get; set; }
    }
}
