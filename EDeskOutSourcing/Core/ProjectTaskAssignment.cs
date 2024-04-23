using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTaskAssignmentTable")]
    public class ProjectTaskAssignment
    {
        [Key]
        public Int64 ProjectTaskAssignementId { get; set; }
        public Int64 ProjectTaskId { get; set; }
        public virtual ProjectTask ProjectTask { get; set; }
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelaner { get; set; }
        public DateTime AssignedDate{ get; set; }
        public DateTime ExpectedCompletionDate { get; set; }


    }
}
