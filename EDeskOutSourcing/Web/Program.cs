using Infra;
using Microsoft.Build.Framework;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repo;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(
    opt =>
    {
        opt.Cookie.HttpOnly = true;
        opt.IdleTimeout = TimeSpan.FromMinutes(20);
        opt.Cookie.IsEssential = true;
    }
    );
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<EDeskContext>(
    opt => opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("scon"))
    );

builder.Services.AddScoped<IAdmin, AdminRepo>();
builder.Services.AddScoped<ICountryRepo, CountryRepo>();
builder.Services.AddScoped<ICityRepo, CityRepo>();
builder.Services.AddScoped<IStateRepo, StateRepo>();    
builder.Services.AddScoped<ICompany, CompanyRepo>();
builder.Services.AddScoped<ICompanyFAQRepo, CompanyFAQRepo>();
builder.Services.AddScoped<IFreelancerFAQRepo, FreelancerFAQRepo>();
builder.Services.AddScoped<ITNCCompanyRepo, TNCCompanyRepo>();
builder.Services.AddScoped<ITNCFreelancerRepo, TNCFreelancerRepo>();
builder.Services.AddScoped<IPaymentModeRepo, PaymentModeRepo>();
builder.Services.AddScoped<ISkillCategoryRepo, SkillCategoryRepo>();
builder.Services.AddScoped<IEducationRepo,EducationRepo>();
builder.Services.AddScoped<ILocationRepo,LocationRepo>();
builder.Services.AddScoped<IProjectRepo, ProjectRepo>();
builder.Services.AddScoped<IProjectStageRepo, ProjectStageRepo>();
builder.Services.AddScoped<IProjectDocumentRepo, ProjectDocumentRepo>();
builder.Services.AddScoped<IFreelancerRepo, FreelancerRepo>();
builder.Services.AddScoped<IFreelancerExperienceRepo, FreelancerExperienceRepo>();
builder.Services.AddScoped<IFreelancerEducationRepo, FreelancerEducationRepo>();
builder.Services.AddScoped<IFreelancerPriviousProjectsRepo,FreelancerPriviousProjectsRepo>();
builder.Services.AddScoped<IFreelancerCertificationsRepo, FreelancerCertificationsRepo>();
builder.Services.AddScoped<ISkillRepo, SkillRepo>();
builder.Services.AddScoped<ITechnologiesRepo, TechnologiesRepo>();
builder.Services.AddScoped<IProjectTechnologyRepo, ProjectTechnologyRepo>();
builder.Services.AddScoped<IProjectSkillRepo, ProjectSkillRepo>();
builder.Services.AddScoped<IProjectApplicationRepo, ProjectApplicationRepo>();

var app = builder.Build();
app.UseStaticFiles();
app.UseSession();
app.MapControllerRoute(
    name: "areas",
    pattern:"{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
app.MapDefaultControllerRoute();
app.Run();
