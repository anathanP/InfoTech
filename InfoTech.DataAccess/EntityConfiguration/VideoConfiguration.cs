using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    public class VideoConfiguration : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder
                .HasData(
                    new Video { Id = 1, Title = "َAbout Us Video", Link = "https://www.youtube.com/watch?v=Cn4G2lZ_g2I" }
                );
        }
    }
}
