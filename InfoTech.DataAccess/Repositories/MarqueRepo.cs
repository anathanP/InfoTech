using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    public class MarqueRepo : Repository<Marque>, IMarqueRepo
    {
        private readonly DbSet<Marque> _dbSet;
        public MarqueRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<Marque>();
        }

        public void Update(Marque marque)
        {
            _dbSet.Update(marque);
        }
    }
}
