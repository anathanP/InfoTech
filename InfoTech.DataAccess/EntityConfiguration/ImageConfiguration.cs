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
                    }
                );
        }
    }
}
