using CodeQuizApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CodeQuizApi.Database
{
    public class MainDbContext : DbContext
    {
        public DbSet<Problem> Problems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=data.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Problem>().ToTable("Problems");
        }
    }
}
