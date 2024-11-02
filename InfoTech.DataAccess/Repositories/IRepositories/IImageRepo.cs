using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IImageRepo : IRepository<Image>
    {
        void Update(Image image);
    }
}
