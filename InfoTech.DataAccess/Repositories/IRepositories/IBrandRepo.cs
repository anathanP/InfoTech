using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IBrandRepo : IRepository<Brand>
    {
        void Update(Brand brand);
    }
}
