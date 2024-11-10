using Microsoft.EntityFrameworkCore;

namespace StudentDatabaseApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=StudentDb;Trusted_Connection=True;");
        }
    }
}