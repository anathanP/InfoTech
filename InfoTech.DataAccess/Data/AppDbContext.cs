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
        public DbSet<Page> Pages { get; set; }
        public DbSet<SubPage> SubPages { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }
        public DbSet<HeroBanner> HeroBanners { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ImageConfiguration());
            modelBuilder.ApplyConfiguration(new PageConfiguration());
            modelBuilder.ApplyConfiguration(new EmailConfiguration());
            modelBuilder.ApplyConfiguration(new PhoneConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new SocialMediaConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new WorkTimeConfiguration());
            modelBuilder.ApplyConfiguration(new HeroBannerConfiguration());
        }
    }
}
