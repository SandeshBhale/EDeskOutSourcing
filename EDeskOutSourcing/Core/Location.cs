using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("LocationTable")]
    public class Location
    {
        [Key]
        public Int64 LocationId { get; set; }
        public string LocationName { get; set; }
        public Int64 CityId { get; set; }
        public City City { get; set; }
    }
}
