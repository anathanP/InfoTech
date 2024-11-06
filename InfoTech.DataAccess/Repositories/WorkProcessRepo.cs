using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    internal class WorkProcessRepo : Repository<WorkProcess>, IWorkProcessRepo
    {
        private readonly DbSet<WorkProcess> _dbSet;
        public WorkProcessRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<WorkProcess>();
        }

        public void Update(WorkProcess workProcess)
        {
            _dbSet.Update(workProcess);
        }
    }
}
