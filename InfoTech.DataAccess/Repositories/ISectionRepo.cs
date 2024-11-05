using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    public class SectionRepo : Repository<Section>, ISectionRepo
    {
        private readonly DbSet<Section> _dbSet;
        public SectionRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<Section>();
        }

        public void Update(Section section)
        {
            _dbSet.Update(section);
        }
    }
}
