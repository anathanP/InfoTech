using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    internal class ImageRepo : Repository<Image>, IImageRepo
    {
        private readonly DbSet<Image> _dbSet;
        public ImageRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<Image>();
        }

        public void Update(Image image)
        {
            _dbSet.Update(image);
        }
    }
}
