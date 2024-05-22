using Core;
using Infra;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class SelectedApplicationRepo : GenRepo<SelectedApplications>, ISelectedApplicationRepo
    {
        EDeskContext ec;

        public SelectedApplicationRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }


        public List<SelectedApplications> GetAllNotAssignedProjects(long id)
        {
            var V = from t in this.ec.SelectedApplications
                    join t2 in this.ec.ProjectApplications
                    on t.ProjectApplicationId equals t2.ProjectApplicationId
                    where t2.Project.CompanyId == id &&
                     !(from t1 in this.ec.ProjectAssigneds 
                          select t1.SelectedApplicationId).Contains(t.SelectedApplicationId)
                          select t;
            return V.ToList();
        }

        public List<SelectedApplications> GetByCompanyId(long id)
        {
            //var v = this.ec.SelectedApplications.Where(p => p.ProjectApplications.Project.CompanyId == id).ToList();
            //return v;

            var v = from t in ec.SelectedApplications
                    join t1 in ec.SelectedApplications
                    on t.SelectedApplicationId equals t1.SelectedApplicationId
                    join t2 in ec.ProjectApplications
                    on t1.ProjectApplicationId equals t2.ProjectApplicationId
                    where t2.Project.CompanyId == id
                    select t;

            return v.ToList();
        }
    }
}
