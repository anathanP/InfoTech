using InfoTech.DataAccess.EntityConfiguration;
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

        public DbSet<Email>? Emails { get; set; }
        public DbSet<Phone>? Phones { get; set; }
        public DbSet<Language>? Languages { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
        }
    }
}
