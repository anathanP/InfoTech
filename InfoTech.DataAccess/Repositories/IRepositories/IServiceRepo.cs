using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IServiceRepo : IRepository<Service>
    {
        void Update(Service service);
    }
}
