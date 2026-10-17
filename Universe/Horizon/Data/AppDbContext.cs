using Horizon.Models;
using Microsoft.EntityFrameworkCore;

namespace Horizon.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=H\\SQLEXPRESS;Database=Universe;TrustServerCertificate=True;Trusted_Connection=True");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // Data Seeding
        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee() { Id = 1, FullName = "Osama Ahmed Hassan", Position = "Developer", Salary = 17500m, NationalId = "111122233344455", Country = "Egypt" },
        //        new Employee() { Id = 2, FullName = "Wael Ali Omar", Position = "Tester", Salary = 12500m, NationalId = "10002000300044", Country = "Kuwait" },
        //        new Employee() { Id = 3, FullName = "Bahaa Hussain Othman", Position = "Senior Developer", Salary = 23500m, NationalId = "10102303304455", Country = "Egypt" },
        //        new Employee() { Id = 4, FullName = "Ayman Saad Mostafa", Position = "Senior Tester", Salary = 19300m, NationalId = "10020030040066", Country = "Oman" },
        //        new Employee() { Id = 5, FullName = "Hossam Ali Mamdouh", Position = "Junior Developer", Salary = 15250m, NationalId = "50060070080099", Country = "Egypt" }
        //    );
        //}


    
}
}
