using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .HasData(
                    new Project
                    {
                        Id = 1, Title = "پروژه یک", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 22, ServiceId = 1 

                    },
                    new Project
                    {
                        Id = 2, Title = "سیبهشتسک", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 23, ServiceId = 2 

                    },
                    new Project
                    {
                        Id = 3, Title = "سبیشثهشی", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 24, ServiceId = 3 

                    },
                    new Project
                    {
                        Id = 4, Title = "تست پروژه", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 25, ServiceId = 4
                    },
                    new Project
                    {
                        Id = 5, Title = "پروژه تستی", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 26, ServiceId = 5 

                    },
                    new Project
                    {
                        Id = 6, Title = "پروژه تستی", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 27, ServiceId = 2 

                    },
                    new Project
                    {
                        Id = 7, Title = "پروژه تستی", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 28, ServiceId = 1 

                    },
                    new Project
                    {
                        Id = 8, Title = "پروژه تستی", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 29, ServiceId = 4 

                    },
                    new Project
                    {
                        Id = 9, Title = "پروژه تستی", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 30, ServiceId = 3 

                    },
                    new Project
                    {
                        Id = 10, Title = "پروژه تستی", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 31, ServiceId = 5 

                    },
                    new Project
                    {
                        Id = 11, Title = "پروژه تستی", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 32, ServiceId = 3 

                    },
                    new Project
                    {
                        Id = 12, Title = "پروژه تستی", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 33, ServiceId = 2 

                    },
                    new Project
                    {
                        Id = 13, Title = "پروژه تستی", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 34, ServiceId = 1 

                    },
                    new Project
                    {
                        Id = 14, Title = "پروژه تستی", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 35, ServiceId = 5 

                    },
                    new Project
                    {
                        Id = 15, Title = "پروژه تستی", Description = "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", Content = "", ImageId = 36, ServiceId = 5 

                    }
                );
        }
    }
}
