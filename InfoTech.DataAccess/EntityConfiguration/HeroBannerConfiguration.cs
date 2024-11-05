using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    internal class HeroBannerConfiguration : IEntityTypeConfiguration<HeroBanner>
    {
        public void Configure(EntityTypeBuilder<HeroBanner> builder)
        {
            builder
                .HasData(
                    new HeroBanner
                    {
                        Id = 1, Tag = "بهترین شرکت", Title = "کسب و کار ما را دریافت کنید بهترین راه حل",
                        Description =
                            "آموزش شکلات برنزی و ارتقای عمر محصول را به دنبال خواهد داشت. همه می خواهند تکالیف خود را در دوره انجام دهند، اما اعضای مدرسه به آن نیاز دارند",
                        FillButtonCaption = "با ما تماس بگیرید", EmptyButtonCaption = "بیشتر کاوش کنید", ImageId = 4 , EmptyButtonAction = "/Customer/Home/About", FillButtonAction = "/Customer/Home/Contact"
                    },
                    new HeroBanner
                    {
                        Id = 2, Tag = "بهترین شرکت", Title = "کسب و کار ما را دریافت کنید بهترین راه حل",
                        Description =
                            "آموزش شکلات برنزی و ارتقای عمر محصول را به دنبال خواهد داشت. همه می خواهند تکالیف خود را در دوره انجام دهند، اما اعضای مدرسه به آن نیاز دارند",
                        FillButtonCaption = "با ما تماس بگیرید", EmptyButtonCaption = "بیشتر کاوش کنید", ImageId = 5 , EmptyButtonAction = "/Customer/Home/About", FillButtonAction = "/Customer/Home/Contact"
                    },
                    new HeroBanner
                    {
                        Id = 3, Tag = "بهترین شرکت", Title = "کسب و کار ما را دریافت کنید بهترین راه حل",
                        Description =
                            "آموزش شکلات برنزی و ارتقای عمر محصول را به دنبال خواهد داشت. همه می خواهند تکالیف خود را در دوره انجام دهند، اما اعضای مدرسه به آن نیاز دارند",
                        FillButtonCaption = "با ما تماس بگیرید", EmptyButtonCaption = "بیشتر کاوش کنید", ImageId = 6 , EmptyButtonAction = "/Customer/Home/About", FillButtonAction = "/Customer/Home/Contact"
                    }
                    
                );
        }
    }
}
