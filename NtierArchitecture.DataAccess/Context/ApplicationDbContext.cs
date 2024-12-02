using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using NtierArchitecture.Entities.Models;
using System.Configuration;

namespace NtierArchitecture.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        

       
        public DbSet<Department> Departments { get; set; }
        public DbSet<Discontinuity> Discontinuities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Leave> Leaves { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=PersonelYonetimiDb;User=sa;Password=Password12*;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
