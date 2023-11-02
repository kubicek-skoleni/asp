using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Metadata;
using TelefonniSeznam.Models;

namespace TelefonniSeznam.Data
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
