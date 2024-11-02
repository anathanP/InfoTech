using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IEmailRepo : IRepository<Email>
    {
        void Update(Email email);
    }
}
