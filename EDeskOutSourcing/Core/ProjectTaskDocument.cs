using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("ProjectTaskDocumentTable")]
    public class ProjectTaskDocument
    {
        [Key]
        public Int64 ProjectTaskDocumentId { get; set; }
        public Int64 TaskId { get; set; }
        public virtual Task Task { get; set; }
        public string ProjectDocumentFilePath { get; set; }
    }
}
