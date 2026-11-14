using Microsoft.EntityFrameworkCore;

namespace DBRepository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<School> School { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TestDB;Integrated Security=true;TrustServerCertificate=true;");
        }
    }
}
