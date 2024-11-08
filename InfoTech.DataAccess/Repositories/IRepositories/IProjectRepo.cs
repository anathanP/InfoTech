using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IProjectRepo : IRepository<Project>
    {
        void Update(Project project);
    }
}
