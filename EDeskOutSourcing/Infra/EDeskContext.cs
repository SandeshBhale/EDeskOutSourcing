using Core;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class EDeskContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Admin>().HasData(
                new Admin()
                {
                    AdminId = 1,
                    FirstName = "Sandesh",
                    LastName = "Bhale",
                    Email = "sandesh@gmail.com",
                    Password = "1234",
                }
                );
            ;;
        }
        public EDeskContext(DbContextOptions<EDeskContext> opt) : base(opt) 
        { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
