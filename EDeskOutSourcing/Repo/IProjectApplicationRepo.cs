using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IProjectApplicationRepo : IGenRepo<ProjectApplications>
    {
        List<ProjectApplications> GetAllByFreelancerId(Int64 id);
        List<FreelancerExperience> GetFreelancerExperienceById(Int64 id);
        List<FreelancerEducation> GetFreelancerEducationById(Int64 id);
        List<FreelancerPriviousProjects> GetFreelancerPriviousProjectsById(Int64 id);
        List<FreelancerCertifications> GetFreelancerCertificationsById(Int64 id);
        List<ProjectApplications> GetByCompanyId(Int64 id);

    }
}
