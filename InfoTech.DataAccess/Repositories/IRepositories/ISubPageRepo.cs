using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface ISubPageRepo : IRepository<SubPage>
    {
        void Update(SubPage subPage);
    }
}
