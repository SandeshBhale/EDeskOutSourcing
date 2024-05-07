using Core;
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

        //public List<Project> SearchByProperty(long skill = 0, long tech = 0, long term = 0)
        //{
        //    //if (skill != 0 && tech != 0 && term != 0)
        //    //{
        //    //    return this.ec.Projects.Where(p => p.SkillId == skill && p.TechId == tech && p.TermId == term).ToList();
        //    //}
        //    //else if (skill != 0 && tech != 0)
        //    //{
        //    //    return this.ec.Projects.Where(p => p.SkillId == skill && p.TechId == tech).ToList();
        //    //}
        //    //else if (skill != 0 && term != 0)
        //    //{
        //    //    return this.ec.Projects.Where(p => p.SkillId == skill && p.TermId == term).ToList();
        //    //}
        //    //else if (tech != 0 && term != 0)
        //    //{
        //    //    return this.ec.Projects.Where(p => p.TechId == tech && p.TermId == term).ToList();
        //    //}
        //    //else if (skill != 0)
        //    //{
        //    //    return this.ec.Projects.Where(p => p.SkillId == skill).ToList();
        //    //}
        //    //else if (tech != 0)
        //    //{
        //    //    return this.ec.Projects.Where(p => p.TechId == tech).ToList();
        //    //}
        //    //else if (term != 0)
        //    //{
        //    //    return this.ec.Projects.Where(p => p.TermId == term).ToList();
        //    //}
        //    //else
        //    //{
        //    //    // If no conditions are provided, return all projects
        //    //    return this.ec.Projects.ToList();
        //    //}
        //}


    }
}
