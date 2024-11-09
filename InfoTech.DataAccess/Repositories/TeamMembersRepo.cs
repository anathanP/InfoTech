using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    public class TeamMembersRepo : Repository<TeamMember>, ITeamMemberRepo
    {
        private readonly DbSet<TeamMember> _dbSet;
        public TeamMembersRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<TeamMember>();
        }

        public void Update(TeamMember teamMember)
        {
            _dbSet.Update(teamMember);
        }
    }
}
