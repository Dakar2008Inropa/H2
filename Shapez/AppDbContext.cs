using Microsoft.EntityFrameworkCore;
using Shapez.Models;

namespace Shapez
{
    public class AppDbContext : DbContext
    {
        public DbSet<Shape> Shapes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=INROPAPC-DANIEL\MSSQLSERVER_D;Initial Catalog=Shapez;Integrated Security=True;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shape>().HasIndex(s => s.Color).HasDatabaseName("IX_Color");
        }
    }
}