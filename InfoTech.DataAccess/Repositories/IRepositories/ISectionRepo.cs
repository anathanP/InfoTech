using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface ISectionRepo : IRepository<Section>
    {
        void Update(Section section);

    }
}
