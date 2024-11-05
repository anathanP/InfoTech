using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    public class AboutTagRepo : Repository<AboutTag>, IAboutTagRepo
    {
        private readonly DbSet<AboutTag> _dbSet;
        public AboutTagRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<AboutTag>();
        }

        public void Update(AboutTag aTag)
        {
            _dbSet.Update(aTag);
        }
    }
}
