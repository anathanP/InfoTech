using InfoTech.Models;
using InfoTech.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    internal class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder
                .HasData(
                    new Language { Id = 1, Name = "فارسی", Status = Sd.Status.Active, Active = true, ImageId = 1 },
                    new Language { Id = 2, Name = "English", Status = Sd.Status.Active, Active = false, ImageId = 2 }
                );
        }
    }
}
