using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    internal class HeroBannerRepo : Repository<HeroBanner>, IHeroBannerRepo
    {
        private readonly DbSet<HeroBanner> _dbSet;
        public HeroBannerRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<HeroBanner>();
        }

        public void Update(HeroBanner entity)
        {
            _dbSet.Update(entity);
        }
    }
}
