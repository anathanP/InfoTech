using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    internal class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder
                .HasData(
                    new Brand {Id = 1, Name = "برند نو", ImageId = 8},
                    new Brand {Id = 2, Name = "برند نو", ImageId = 9},
                    new Brand {Id = 3, Name = "برند نو", ImageId = 10},
                    new Brand {Id = 4, Name = "برند نو", ImageId = 11}
                );
        }
    }
}
