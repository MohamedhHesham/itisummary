using Microsoft.EntityFrameworkCore;
using BrightStars.Models;

namespace BrightStars.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=H\\SQLEXPRESS;Database=BrightStars;" +
                "TrustServerCertificate=True;Trusted_Connection=True");
            }

    }
}
