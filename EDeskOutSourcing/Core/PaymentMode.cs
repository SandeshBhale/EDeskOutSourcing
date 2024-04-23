using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("PaymentModeTable")]
    public class PaymentMode
    {
        [Key]
        public Int64 PaymentModeId { get; set; }
        public string PayMode { get; set; }
    }
}
