using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public class BrandRepo : Repository<Brand>, IBrandRepo
    {
        private readonly DbSet<Brand> _dbSet;
        public BrandRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<Brand>();
        }

        public void Update(Brand brand)
        {
            _dbSet.Update(brand);
        }
    }
}
