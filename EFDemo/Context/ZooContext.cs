using Microsoft.EntityFrameworkCore;

namespace EFDemo.Models
{
    public class ZooContext : DbContext
    {
        public ZooContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Zoo> Zoos { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zoo>()
                .ToTable("Zoos");

            modelBuilder.Entity<Employee>()
                .ToTable("Employees");

            modelBuilder.Entity<Animal>()
                .ToTable("Animals");
        }
    }
}