using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    internal class AboutTagConfiguration : IEntityTypeConfiguration<AboutTag>
    {
        public void Configure(EntityTypeBuilder<AboutTag> builder)
        {
            builder
                .HasData(
                    new AboutTag { Id = 1, Tag = "هویت برند و طراحی" },
                    new AboutTag { Id = 2, Tag = " راه حل های بازاریابی وب سایت" },
                    new AboutTag { Id = 3, Tag = "داده های دانلود نامحدود" }
                );
        }
    }
}
