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
        }
    }
}
