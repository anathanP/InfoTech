using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IPhoneRepo : IRepository<Phone>
    {
        void Update(Phone phone);
    }
}
