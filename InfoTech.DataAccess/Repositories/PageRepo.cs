using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    public class PageRepo : Repository<Page>, IPageRepo
    {
        private readonly DbSet<Page> _dbSet;
        public PageRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<Page>();
        }

        public void Update(Page page)
        {
            _dbSet.Update(page);
        }
    }
}
