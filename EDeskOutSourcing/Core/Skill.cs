using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("SkillTable")]
    public class Skill
    {
        [Key]
        public Int64 SkillId { get; set; }
        public string SkillName { get; set; }
        public Int64 SkillCategoryId { get; set; }
        public SkillCategory SkillCategory { get; set; }
    }
}
