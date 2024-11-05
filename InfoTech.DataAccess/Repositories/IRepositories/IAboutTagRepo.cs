using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IAboutTagRepo : IRepository<AboutTag>
    {
        void Update(AboutTag aTag);
    }
}
