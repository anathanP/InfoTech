using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    internal class SocialMediaRepo : Repository<SocialMedia>, ISocialMediaRepo
    {
        private readonly DbSet<SocialMedia> _dbSet;
        public SocialMediaRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<SocialMedia>();
        }

        public void Update(SocialMedia socialMedia)
        {
            _dbSet.Update(socialMedia);
        }
    }
}
