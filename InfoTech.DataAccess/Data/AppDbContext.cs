﻿using InfoTech.DataAccess.EntityConfiguration;
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
        public DbSet<Section> Sections { get; set; }
        public DbSet<AboutTag> AboutTags { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<WorkProcess> WorkProcesses { get; set; }
        public DbSet<Project> Projects { get; set; }
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
            modelBuilder.ApplyConfiguration(new SectionConfiguration());
            modelBuilder.ApplyConfiguration(new AboutTagConfiguration());
            modelBuilder.ApplyConfiguration(new VideoConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration(new WorkProcessConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
        }
    }
}
