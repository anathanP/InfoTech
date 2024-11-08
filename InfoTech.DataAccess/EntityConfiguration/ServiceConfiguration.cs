using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    internal class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {

            builder
                .HasMany(s => s.Projects)
                .WithOne(p => p.Service)
                .HasForeignKey(p => p.ServiceId)
                .IsRequired()
                .OnDelete(deleteBehavior: DeleteBehavior.NoAction);

            builder
                .HasData(
                    new Service
                    {
                        Id = 1, Name = "امنیت سایبری", Description = "سرویسی که این شرکت ارایه میدهد", ImageId = 12, Content = ""
                    },new Service
                    {
                        Id = 2, Name = "فناوری اطلاعات", Description = "سرویسی که این شرکت ارایه میدهد", ImageId = 13, Content = ""
                    },new Service
                    {
                        Id = 3, Name = "توسعه برنامه", Description = "سرویسی که این شرکت ارایه میدهد", ImageId = 14, Content = ""
                    },new Service
                    {
                        Id = 4, Name = "بازاریابی دیجیتال", Description = "سرویسی که این شرکت ارایه میدهد", ImageId = 15, Content = ""
                    },new Service
                    {
                        Id = 5, Name = "تحلیل داده", Description = "سرویسی که این شرکت ارایه میدهد", ImageId = 16, Content = ""
                    }
                );
        }
    }
}
