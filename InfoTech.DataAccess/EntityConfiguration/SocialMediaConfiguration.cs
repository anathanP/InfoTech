using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    public class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            builder
                .HasData(
                    new SocialMedia
                    {
                        Id = 1, Media = "Telegram", Icon = "<i class=\"bi bi-telegram\"></i>",
                        Link = "https://www.t.me/Abbasmasoud"
                    },
                    new SocialMedia
                    {
                        Id = 2, Media = "Whatsapp", Icon = "<i class=\"bi bi-whatsapp\"></i>",
                        Link = "+989369043949"
                    },
                    new SocialMedia
                    {
                        Id = 3, Media = "Instagram", Icon = "<i class=\"bi bi-instagram\"></i>",
                        Link = "https://www.instagram.com/leoneltech1?igsh=MXBycmQybXQ0bmVjaw=="
                    },
                    new SocialMedia
                    {
                        Id = 4, Media = "LinkedIn", Icon = "<i class=\"bi bi-linkedin\"></i>",
                        Link = "https://www.linkedin.com/in/abbas-masoud-0681a5315?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_mdeium=android_app"
                    }
                );
        }
    }
}
