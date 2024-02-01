using CodeQuizApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeQuizApi.Database
{
    public class MainDbContext : DbContext
    {
        public DbSet<Problem> Problems { get; set; }

        public MainDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Problem>().ToTable("Problems");
        }
    }
}