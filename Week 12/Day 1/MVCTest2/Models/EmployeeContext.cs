using Microsoft.EntityFrameworkCore;

namespace MVCTest2.Models
{
    // database
    public class EmployeeContext : DbContext
    {
        // constructor, utilizes base class implementation
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        // tables
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        // data seeding: adding dummy data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { DeptId = 1, DeptName = "HR" },
                new Department { DeptId = 2, DeptName = "Finance" },
                new Department { DeptId = 3, DeptName = "IT" },
                new Department { DeptId = 4, DeptName = "Marketing" }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Sarah", Dept = Dept.HR, Email = "sarah@company.com", ImageName = "sarah.jpg", Address = "NY", Age = 33 },
                new Employee { Id = 2, Name = "Michael", Dept = Dept.IT, Email = "michael@company.com", ImageName = "michael.jpg", Address = "AL", Age = 29 },
                new Employee { Id = 3, Name = "Logan", Dept = Dept.Finance, Email = "logan@company.com", ImageName = "logan.jpg", Address = "CA", Age = 42 }
                );
        }
    }
}
