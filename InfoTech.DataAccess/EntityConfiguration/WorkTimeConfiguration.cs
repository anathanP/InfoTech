using InfoTech.Models;
using InfoTech.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    public class WorkTimeConfiguration : IEntityTypeConfiguration<WorkTime>
    {
        public void Configure(EntityTypeBuilder<WorkTime> builder)
        {
            builder
                .HasData(
                    new WorkTime
                    {
                        Id = 1, StartDay = Sd.DayOfWeek.Saturday, EndDay = Sd.DayOfWeek.Wednesday,
                        StartTime = new TimeOnly(8, 0), EndTime = new TimeOnly(18, 0)
                    },
                    new WorkTime
                    {
                        Id = 2, StartDay = Sd.DayOfWeek.Thursday, StartTime = new TimeOnly(8, 0), EndTime = new TimeOnly(14, 0)
                    }
                );
        }
    }
}
