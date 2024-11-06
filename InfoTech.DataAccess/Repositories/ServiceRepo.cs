using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    public class ServiceRepo : Repository<Service>, IServiceRepo
    {
        private readonly DbSet<Service> _dbSet;
        public ServiceRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<Service>();
        }

        public void Update(Service service)
        {
            _dbSet.Update(service);
        }
    }
}
