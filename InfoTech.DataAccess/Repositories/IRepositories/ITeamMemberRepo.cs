using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface ITeamMemberRepo : IRepository<TeamMember>
    {
        void Update(TeamMember teamMember);
    }
}
