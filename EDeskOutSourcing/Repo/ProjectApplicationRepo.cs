using Core;
using Infra;
using Infra.Migrations;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class ProjectApplicationRepo : GenRepo<ProjectApplications>, IProjectApplicationRepo
    {
        EDeskContext ec;

        public ProjectApplicationRepo(EDeskContext ec) : base(ec)
        {
            this.ec = ec;
        }

        public List<ProjectApplications> GetAllByFreelancerId(long id)
        {
            return this.ec.ProjectApplications.Where(p => p.ProjectApplicationId == id).ToList();
        }

        public List<FreelancerCertifications> GetFreelancerCertificationsById(long id)
        {
            return ec.FreelancerCertifications.Where(p => p.FreelancerId == id).ToList();
        }

        public List<FreelancerEducation> GetFreelancerEducationById(long id)
        {
            return ec.FreelancerEducations.Where(p => p.FreelancerId == id).ToList();
        }

        public List<FreelancerExperience> GetFreelancerExperienceById(long id)
        {
            return ec.FreelancerExperiences.Where(p => p.FreelancerId == id).ToList();
        }

        public List<FreelancerPriviousProjects> GetFreelancerPriviousProjectsById(long id)
        {
            return ec.FreelancerPriviousProjects.Where(p => p.FreelancerId == id).ToList();
        }
    }
}
