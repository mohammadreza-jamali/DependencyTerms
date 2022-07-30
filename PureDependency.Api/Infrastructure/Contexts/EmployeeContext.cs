using Microsoft.EntityFrameworkCore;
using PureDependency.Api.Entity;

namespace PureDependency.Api.Infrastructure.Contexts
{
    public class EmployeeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\Dependency.sqlite");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(x => x.Id);
            modelBuilder.Entity<Employee>().Property(x=>x.Id).ValueGeneratedOnAdd() ;
        }

        public DbSet<Employee> Employees { set; get; }
    }
}
