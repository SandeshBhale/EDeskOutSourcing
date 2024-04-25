using Core;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Infra
{
    public class EDeskContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder mb)
        {

            foreach (var relationship in mb.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public EDeskContext(DbContextOptions<EDeskContext> opt) : base(opt) 
        { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyFAQ> CompaniesFAQ { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<FinishedProject> FinishedProjects { get; set; }
        public DbSet<Freelancer> Freelancers { get; set;}
        public DbSet<FreelancerCertifications> FreelancerCertifications { get; set; }
        public DbSet<FreelancerEducation> FreelancerEducations { get; set; }
        public DbSet<FreelancerExperience> FreelancerExperiences { get; set; }
        public DbSet<FreelancerFAQ> FreelancerFAQ { get;set; }
        public DbSet<FreelancerPriviousProjects> FreelancerPriviousProjects { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<PaymentMode> PaymentModes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectApplications> ProjectApplications { get; set; }
        public DbSet<ProjectAssigned> ProjectAssigneds { get; set; }
        public DbSet<ProjectDocument> ProjectDocuments { get; set; }
        public DbSet<ProjectStages> ProjectStages { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<ProjectTaskAssignment> ProjectTaskAssignments { get; set; }
        public DbSet<ProjectTaskDocument> ProjectTaskDocuments { get; set; }
        public DbSet<ProjectTaskQuery> ProjectTaskQueries { get; set; }
        public DbSet<ProjectTaskQuerySolution> ProjectTaskQuerySolutions { get; set; }
        public DbSet<ProjectTaskReport> ProjectTaskReports { get; set; }
        public DbSet<ProjectTaskReportConflict> ProjectTaskReportConflicts { get; set;}
        public DbSet<ProjectTaskReportConflictSolution> ProjectTaskReportConflictsSolutions { get; set; }
        public DbSet<ProjectTaskReportReleasePayment> ProjectTaskReportReleasePayment { get; set; }
        public DbSet<ProjectTaskReportReleasePaymentConflict> ProjectTaskReportReleasePaymentConflicts { get; set; }
        public DbSet<ProjectTaskReportReleasePaymentConflictSolution> ProjectTaskReportReleasePaymentConflictSolutions { get; set; }
        public DbSet<SelectedApplications> SelectedApplications { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<SkillCategory> SkillCategories { get; set; }
        public DbSet<Technologies> Technologies { get; set; }
        public DbSet<TerminatedProject> TerminatedProjects { get; set;}
        public DbSet<TNCCompany> TNCCompany { get; set; }
        public DbSet<TNCFreelancer> TNCFreelancers { get; set; }
    
    }
}
