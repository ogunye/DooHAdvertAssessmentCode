using DooHAdvertAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DooHAdvertAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.ApplyConfiguration(new AdvertSeedConfiguration());
        }
               
        public DbSet<Adverts> Adverts { get; set; }

    }
}
