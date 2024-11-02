using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Data
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            :base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Email> Emails { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
