using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    public class MarqueConfiguration : IEntityTypeConfiguration<Marque>
    {
        public void Configure(EntityTypeBuilder<Marque> builder)
        {
            builder
                .HasData(
                    new Marque { Id = 1, Title = "امنیت سایبری", Name = "امنیت سایبری" },
                    new Marque { Id = 2, Title = "راه حل اطلاعاتی", Name = "راه حل اطلاعاتی" },
                    new Marque { Id = 3, Title = "فن آوری", Name = "فن آوری" },
                    new Marque { Id = 4, Title = "امنیت سایبری", Name = "امنیت سایبری" },
                    new Marque { Id = 6, Title = "امنیت سایبری", Name = "امنیت سایبری" },
                    new Marque { Id = 7, Title = "امنیت سایبری", Name = "امنیت سایبری" },
                    new Marque { Id = 8, Title = "امنیت سایبری", Name = "امنیت سایبری" },
                    new Marque { Id = 9, Title = "امنیت سایبری", Name = "امنیت سایبری" },
                    new Marque { Id = 10, Title = "امنیت سایبری", Name = "امنیت سایبری" },
                    new Marque { Id = 11, Title = "امنیت سایبری", Name = "امنیت سایبری" },
                    new Marque { Id = 12, Title = "امنیت سایبری", Name = "امنیت سایبری" },
                    new Marque { Id = 5, Title = "امنیت سایبری", Name = "امنیت سایبری" }
                );
        }
        
    }
}
