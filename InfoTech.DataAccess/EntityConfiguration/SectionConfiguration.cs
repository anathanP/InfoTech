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
                }
            );
        }
    }
}
