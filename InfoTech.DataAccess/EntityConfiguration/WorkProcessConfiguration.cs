using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    internal class WorkProcessConfiguration : IEntityTypeConfiguration<WorkProcess>
    {
        public void Configure(EntityTypeBuilder<WorkProcess> builder)
        {
            builder
                .HasData(
                    new WorkProcess { Id = 1, Step = "یک سرویس را انتخاب کنید", Description = "در یک ساعت آزاد، زمانی که قدرت انتخاب ما بی بند و بار است و", DisplayOrder = 1, ImageId = 18},
                    new WorkProcess { Id = 2, Step = "الزامات را تعریف کنید", Description = "در یک ساعت آزاد، زمانی که قدرت انتخاب ما بی بند و بار است و", DisplayOrder = 2, ImageId = 19},
                    new WorkProcess { Id = 3, Step = "درخواست یک جلسه", Description = "در یک ساعت آزاد، زمانی که قدرت انتخاب ما بی بند و بار است و", DisplayOrder = 3, ImageId = 20},
                    new WorkProcess { Id = 4, Step = "راه حل نهایی 3", Description = "در یک ساعت آزاد، زمانی که قدرت انتخاب ما بی بند و بار است و", DisplayOrder = 4, ImageId = 21}
                );
        }
    }
}
