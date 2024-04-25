using Infra;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repo;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSession(
    opt =>
    {
        opt.Cookie.HttpOnly = true;
        opt.IdleTimeout = TimeSpan.FromSeconds(20);
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

var app = builder.Build();
app.UseStaticFiles();
app.UseSession();
app.MapControllerRoute(
    name: "areas",
    pattern:"{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
app.MapDefaultControllerRoute();
app.Run();
