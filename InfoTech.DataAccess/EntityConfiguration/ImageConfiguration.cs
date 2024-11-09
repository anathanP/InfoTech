using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    internal class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder
                .HasOne(i => i.Language)
                .WithOne(l => l.Image)
                .HasForeignKey<Language>(l => l.ImageId)
                .IsRequired()
                .OnDelete(deleteBehavior: DeleteBehavior.NoAction);

            builder
                .HasOne(i => i.HeroBanner)
                .WithOne(h => h.Image)
                .HasForeignKey<HeroBanner>(h => h.ImageId)
                .IsRequired()
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            builder
                .HasOne(i => i.Brand)
                .WithOne(b => b.Image)
                .HasForeignKey<Brand>(b => b.ImageId)
                .IsRequired()
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            builder
                .HasOne(i => i.Service)
                .WithOne(s => s.Image)
                .HasForeignKey<Service>(s => s.ImageId)
                .IsRequired()
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            builder
                .HasOne(i => i.Project)
                .WithOne(p => p.Image)
                .HasForeignKey<Project>(p => p.ImageId)
                .IsRequired()
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            builder
                .HasOne(i => i.TeamMember)
                .WithOne(t => t.Image)
                .HasForeignKey<TeamMember>(t => t.ImageId)
                .IsRequired()
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            builder
                .HasData(
                    new Image
                    {
                        Id = 1, Address = "flags/Iran-flag.jpeg", Alt = "پرچم کشور ایران", Title = "Iran Flag"
                    },
                    new Image
                    {
                        Id = 2, Address = "flags/England-flag.jpeg", Alt = "English Flag", Title = "England Flag"
                    },
                    new Image
                    {
                        Id = 3, Address = "logo/black-logo.svg", Alt = "لوگوی صفحه", Title = "لوگوی صفحه"
                    },
                    new Image
                    {
                        Id = 4, Address = "hero/hero-2.jpg", Alt = "عکس بنر", Title = "عکس بنر"
                    },
                    new Image
                    {
                        Id = 5, Address = "hero/hero-1.jpg", Alt = "عکس بنر", Title = "عکس بنر"
                    },
                    new Image
                    {
                        Id = 6, Address = "hero/hero-3.jpg", Alt = "عکس بنر", Title = "عکس بنر"
                    },
                    new Image
                    {
                        Id = 7, Address = "about/05.png", Alt = "عکس درباره ما", Title = "عکس درباره ما"
                    },
                    new Image
                    {
                        Id = 8, Address = "brand.png", Alt = "عکس برند", Title = "عکس برند"
                    },
                    new Image
                    {
                        Id = 9, Address = "brand.png", Alt = "عکس برند", Title = "عکس برند"
                    },
                    new Image
                    {
                        Id = 10, Address = "brand.png", Alt = "عکس برند", Title = "عکس برند"
                    },
                    new Image
                    {
                        Id = 11, Address = "brand.png", Alt = "عکس برند", Title = "عکس برند"
                    },
                    new Image
                    {
                        Id = 12, Address = "service/01.jpg", Alt = "عکس سرویس", Title = "عکس سرویس"
                    },
                    new Image
                    {
                        Id = 13, Address = "service/02.jpg", Alt = "عکس سرویس", Title = "عکس سرویس"
                    },
                    new Image
                    {
                        Id = 14, Address = "service/03.jpg", Alt = "عکس سرویس", Title = "عکس سرویس"
                    },
                    new Image
                    {
                        Id = 15, Address = "service/04.jpg", Alt = "عکس سرویس", Title = "عکس سرویس"
                    },
                    new Image
                    {
                        Id = 16, Address = "service/05.jpg", Alt = "عکس سرویس", Title = "عکس سرویس"
                    },
                    new Image
                    {
                        Id = 17, Address = "process/linepng.png", Alt = "عکس پروسه", Title = "عکس پروسه"
                    },
                    new Image
                    {
                        Id = 18, Address = "process/01.png", Alt = "عکس پروسه", Title = "عکس پروسه"
                    },
                    new Image
                    {
                        Id = 19, Address = "process/02.png", Alt = "عکس پروسه", Title = "عکس پروسه"
                    },
                    new Image
                    {
                        Id = 20, Address = "process/03.png", Alt = "عکس پروسه", Title = "عکس پروسه"
                    },
                    new Image
                    {
                        Id = 21, Address = "process/04.png", Alt = "عکس پروسه", Title = "عکس پروسه"
                    },
                    new Image
                    {
                        Id = 22, Address = "project/01.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 23, Address = "project/02.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 24, Address = "project/03.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 25, Address = "project/04.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 26, Address = "project/05.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 27, Address = "project/06.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 28, Address = "project/07.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 29, Address = "project/08.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 30, Address = "project/09.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 31, Address = "project/10.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 32, Address = "project/11.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 33, Address = "project/12.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 34, Address = "project/13.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 35, Address = "project/14.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 36, Address = "project/15.jpg", Alt = "عکس پروژه", Title = "عکس پروژه"
                    },
                    new Image
                    {
                        Id = 37, Address = "team/01.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    },
                    new Image
                    {
                        Id = 38, Address = "team/02.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    },
                    new Image
                    {
                        Id = 39, Address = "team/03.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    },
                    new Image
                    {
                        Id = 40, Address = "team/04.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    },
                    new Image
                    {
                        Id = 41, Address = "team/05.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    },
                    new Image
                    {
                        Id = 42, Address = "team/06.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    },
                    new Image
                    {
                        Id = 43, Address = "team/07.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    },
                    new Image
                    {
                        Id = 44, Address = "team/08.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    },
                    new Image
                    {
                        Id = 45, Address = "team/09.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    },
                    new Image
                    {
                        Id = 46, Address = "team/10.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    },
                    new Image
                    {
                        Id = 47, Address = "team/11.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    },
                    new Image
                    {
                        Id = 48, Address = "team/12.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    },
                    new Image
                    {
                        Id = 49, Address = "team/13.jpg", Alt = "عکس اعضا", Title = "عکس اعضا"
                    }
                );
        }
    }
}
