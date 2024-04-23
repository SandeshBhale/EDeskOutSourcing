using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("StateTable")]
    public class State
    {
        [Key]
        public Int64 StateId { get; set; }
        public String StateName { get; set; }
        public Int64 CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
