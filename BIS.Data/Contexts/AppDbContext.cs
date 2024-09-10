using BIS.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace BIS.Data.Contexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }
		public DbSet<EmployeeStatus> EmployeeStatus { get; set; }
	}
}
