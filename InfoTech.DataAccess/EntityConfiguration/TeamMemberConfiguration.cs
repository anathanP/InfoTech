using InfoTech.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoTech.DataAccess.EntityConfiguration
{
    public class TeamMemberConfiguration : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(EntityTypeBuilder<TeamMember> builder)
        {
            builder
                .HasMany(t => t.SocialMedias)
                .WithOne(s => s.TeamMember)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);

            builder
                .HasData(
                    new TeamMember
                    {
                        Id = 1, Name = "عباس", Family = "مسعوداردکانی", ImageId = 37, Content = "", Description = ""
                    },
                    new TeamMember
                    {
                        Id = 2, Name = "عباس", Family = "مسعوداردکانی", ImageId = 38, Content = "", Description = ""
                    },
                    new TeamMember
                    {
                        Id = 3, Name = "عباس", Family = "مسعوداردکانی", ImageId = 39, Content = "", Description = ""
                    },
                    new TeamMember
                    {
                        Id = 4, Name = "عباس", Family = "مسعوداردکانی", ImageId = 40, Content = "", Description = ""
                    },
                    new TeamMember
                    {
                        Id = 5, Name = "عباس", Family = "مسعوداردکانی", ImageId = 41, Content = "", Description = ""
                    },
                    new TeamMember
                    {
                        Id = 6, Name = "عباس", Family = "مسعوداردکانی", ImageId = 42, Content = "", Description = ""
                    },
                    new TeamMember
                    {
                        Id = 7, Name = "عباس", Family = "مسعوداردکانی", ImageId = 43, Content = "", Description = ""
                    },
                    new TeamMember
                    {
                        Id = 8, Name = "عباس", Family = "مسعوداردکانی", ImageId = 44, Content = "", Description = ""
                    },
                    new TeamMember
                    {
                        Id = 9, Name = "عباس", Family = "مسعوداردکانی", ImageId = 45, Content = "", Description = ""
                    },
                    new TeamMember
                    {
                        Id = 10, Name = "عباس", Family = "مسعوداردکانی", ImageId = 46, Content = "", Description = ""
                    },
                    new TeamMember
                    {
                        Id = 11, Name = "عباس", Family = "مسعوداردکانی", ImageId = 47, Content = "", Description = ""
                    },
                    new TeamMember
                    {
                        Id = 12, Name = "عباس", Family = "مسعوداردکانی", ImageId = 48, Content = "", Description = ""
                    },
                    new TeamMember
                    {
                        Id = 13, Name = "عباس", Family = "مسعوداردکانی", ImageId = 49, Content = "", Description = "" 

                    }
                );
        }
    }
}
