using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    public class VideoRepo : Repository<Video>, IVideoRepo
    {
        private readonly DbSet<Video> _dbSet;
        public VideoRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<Video>();
        }

        public void Update(Video video)
        {
            _dbSet.Update(video);
        }
    }
}
