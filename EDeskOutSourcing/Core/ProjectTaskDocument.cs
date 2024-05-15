using Microsoft.AspNetCore.Http;
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
        public Int64 ProjectTaskId { get; set; }
        public virtual ProjectTask ProjectTask { get; set; }
        public string DocName { get; set; }
        public string ProjectDocumentFilePath { get; set; }
        [NotMapped]
        public IFormFile ActualFile { get; set; }
    }
}
