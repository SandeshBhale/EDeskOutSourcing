﻿using Core;
using Infra;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class ProjectRepo : GenRepo<Project>, IProjectRepo
    {
        EDeskContext ec;

        public ProjectRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public List<Project> GetAllProject()
        {
            return this.ec.Projects.ToList();
        }

        public List<ProjectSkill> GetProjectSkillById(long id)
        {
            return ec.ProjectSkill.Where(p => p.ProjectId == id).ToList();
        }

        public List<ProjectStage> GetProjectStageById(long id)
        {
            return ec.ProjectStages.Where(p => p.ProjectId == id).ToList();
        }

        public List<ProjectTechnology> GetProjectTechnologyById(long id)
        {
            return ec.ProjectTechnology.Where(p => p.ProjectId == id).ToList();
        }

        public List<Project> SearchByProperty(long skill = 0, long tech = 0, long term = 0)
        {
            if (skill != 0 && tech != 0 && term != 0)
            {
                return this.ec.Projects.Where(p => p.ProjectId == skill && p.ProjectId == tech && p.ProjectId == term).ToList();
            }
            else if (skill != 0 && tech != 0)
            {
                return this.ec.Projects.Where(p => p.ProjectId == skill && p.ProjectId == tech).ToList();
            }
            else if (skill != 0 && term != 0)
            {
                return this.ec.Projects.Where(p => p.ProjectId == skill && p.ProjectId == term).ToList();
            }
            else if (tech != 0 && term != 0)
            {
                return this.ec.Projects.Where(p => p.ProjectId == tech && p.ProjectId == term).ToList();
            }
            else if (skill != 0)
            {
                return this.ec.Projects.Where(p => p.ProjectId == skill).ToList();
            }
            else if (tech != 0)
            {
                return this.ec.Projects.Where(p => p.ProjectId == tech).ToList();
            }
            else if (term != 0)
            {
                return this.ec.Projects.Where(p => p.ProjectId == term).ToList();
            }
            else
            {
                // If no conditions are provided, return all projects
                return this.ec.Projects.ToList();
            }
        }


    }
}
