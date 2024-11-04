using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .HasData(
                    new Address
                    {
                        Id = 1, State = "فارس", City = "شیراز", Location = "جاده شیراز-سپیدان, گویم",
                        PostalCode = "2547896548", Block = "0"
                    }
                );
        }
    }
}
