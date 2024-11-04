using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    public class PageConfiguration : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder
                .HasMany(p => p.SubPages)
                .WithOne(s => s.Page)
                .HasForeignKey(s => s.PageId)
                .IsRequired()
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);
        }
    }
}
