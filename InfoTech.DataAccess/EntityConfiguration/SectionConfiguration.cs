using InfoTech.Models;
using InfoTech.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    internal class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasData(
                new Section
                {
                    Id = 1, Tag = "درباره اینفوتک", Title = "بزرگترین شرکت تکنولوژی ایران",
                    Description = "ما در این موسسه افتخار این را داریم که بگوییم بهترین هستیم و همیشه حق با مشتری است",
                    IndexSections = Sd.IndexSections.About, FillButtonCaption = "درباره ما",
                    FillButtonAction = "/Customer/Home/About"
                },
                new Section
                {
                    Id = 2,
                    Title = "برند های که به ما اعتماد کرده اند",
                    IndexSections = Sd.IndexSections.Brand
                },
                new Section
                {
                    Id = 3,
                    Title = "فعالیت های ما در این شرکت",
                    Tag = "سرویس ها",
                    IndexSections = Sd.IndexSections.Service,
                    FillButtonCaption = "سرویس ما",
                    FillButtonAction = "/Customer/Home/Service"
                },
                new Section
                {
                    Id = 4,
                    Title = "پروسه کاری این شرکت",
                    Tag = "نحوه کار",
                    IndexSections = Sd.IndexSections.WorkProcess,
                },
                new Section
                {
                    Id = 5,
                    Title = "پروژه های انجام شده در این شرکت",
                    Tag = "پروژه ها",
                    IndexSections = Sd.IndexSections.Project,
                }
            );
        }
    }
}
