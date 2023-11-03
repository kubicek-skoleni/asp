using EmptyBlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace EmptyBlazorApp1.Data
{
    public class SeznamDbContext : DbContext
    {
        public DbSet<Clovek> Lide { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=(localdb)\\mssqllocaldb;Database=TelSeznamDb;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(conn);
        }
    }
}
