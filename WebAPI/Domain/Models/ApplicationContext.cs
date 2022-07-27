using Microsoft.EntityFrameworkCore;

namespace WebAPI.Domain.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=WebSiteDB;Trusted_Connection=True;");
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}