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
    [Table("ProjectDocumentTable")]
    public class ProjectDocument
    {
        [Key]
        public Int64 ProjectDocumentId { get; set; }
        public string DocName { get; set; }
        public Int64 ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public string DocumentFilePath { get; set; }
        [NotMapped]
        public IFormFile ActualFile { get; set; }
    }
}
