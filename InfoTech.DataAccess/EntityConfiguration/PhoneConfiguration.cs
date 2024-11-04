using InfoTech.Models;
using InfoTech.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    internal class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder
                .HasData(
                    new Phone { Id = 1, Number = "+989369043949", Status = Sd.Status.Active }
                );
        }
    }
}
