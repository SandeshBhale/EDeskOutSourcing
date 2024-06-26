﻿using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IFreelancerExperienceRepo : IGenRepo<FreelancerExperience>
    {
        List<FreelancerExperience> GetAllByFreelancerId(Int64 id);
    }
}
