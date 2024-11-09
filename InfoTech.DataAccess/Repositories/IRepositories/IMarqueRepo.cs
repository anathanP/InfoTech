using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IMarqueRepo : IRepository<Marque>
    {
        void Update(Marque marque);
    }
}
