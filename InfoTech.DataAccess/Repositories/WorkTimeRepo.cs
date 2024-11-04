using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    public class WorkTimeRepo : Repository<WorkTime>, IWorkTimeRepo
    {
        private readonly DbSet<WorkTime> _dbSet;
        public WorkTimeRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<WorkTime>();
        }

        public void Update(WorkTime entity)
        {
            _dbSet.Update(entity);
        }
    }
}
