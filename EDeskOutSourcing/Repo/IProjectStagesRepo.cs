﻿using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IProjectStagesRepo : IGenRepo<ProjectStages>
    {
        void AddRecord(List<ProjectStagesVM> rec);
    }
}
