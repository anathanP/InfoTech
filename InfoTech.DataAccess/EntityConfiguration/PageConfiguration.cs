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

            builder
                .HasData(
                    new Page{Id = 1, Name = "صفحه اصلی", Title = "Home", Author = "Anathan", Description = "صفحه نخست سایت اینفو تک", Keywords = "Home, info tech, C#", Action = "/Customer/Home/Index"},
                    new Page{Id = 2, Name = "درباره", Title = "About Us", Author = "Anathan", Description = "صفحه نخست سایت اینفو تک", Keywords = "Home, info tech, C#", Action = "/Customer/Home/About"},
                    new Page{Id = 3, Name = "خدمات", Title = "Services", Author = "Anathan", Description = "صفحه نخست سایت اینفو تک", Keywords = "Home, info tech, C#", Action = "/Customer/Home/Services"},
                    new Page{Id = 4, Name = "صفحات", Title = "Pages", Author = "Anathan", Description = "صفحه نخست سایت اینفو تک", Keywords = "Home, info tech, C#", Action = "/Customer/Home/Pages"},
                    new Page{Id = 5, Name = "وبلاگ", Title = "Blogs", Author = "Anathan", Description = "صفحه نخست سایت اینفو تک", Keywords = "Home, info tech, C#", Action = "/Customer/Home/Blogs"},
                    new Page{Id = 6, Name = "تماس", Title = "Contact", Author = "Anathan", Description = "صفحه نخست سایت اینفو تک", Keywords = "Home, info tech, C#", Action = "/Customer/Home/Contact"}
                );
        }
    }
}
