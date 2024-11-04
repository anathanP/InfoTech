using InfoTech.Models;
using InfoTech.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    public class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder
                .HasData(
                    new Email { Id = 1, Address = "abbasmasoudardakani@gmail.com", Status = Sd.Status.Active }
                );
        }
    }
}
