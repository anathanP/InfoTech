using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    public class ProjectRepo : Repository<Project>, IProjectRepo
    {
        private readonly DbSet<Project> _dbSet;
        public ProjectRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<Project>();
        }

        public void Update(Project project)
        {
            _dbSet.Update(project);
        }
    }
}
