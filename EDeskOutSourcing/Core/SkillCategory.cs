using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("SkillCategoryTable")]
    public class SkillCategory
    {
        [Key]
        public Int64 SkillCategoryId { get; set; }
        public string SkillCategoryName { get; set; }
    }
}
