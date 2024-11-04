using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IPageRepo : IRepository<Page>
    {
        void Update(Page page);
    }
}
