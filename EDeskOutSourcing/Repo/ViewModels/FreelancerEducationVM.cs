﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.ViewModels
{
    public class FreelancerEducationVM
    {
        public Int64 FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }
        public Int64 EducationId { get; set; }
        public virtual Education Education { get; set; }
        public string PassingYear { get; set; }
        public string UnivercityInstituteName { get; set; }
        public virtual FreelancerEducationsVM FreelancerEducations { get; set; }
    }
}
