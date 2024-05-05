using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectSkillTable")]
    public class ProjectSkill
    {
        [Key]
        public Int64 ProjectSkillId { get; set; }
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public Int64 SkillId { get; set; }
        public virtual Skill Skill { get; set; }
    }

}
