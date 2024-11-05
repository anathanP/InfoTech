using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IVideoRepo : IRepository<Video>
    {
        void Update(Video video);
    }
}
