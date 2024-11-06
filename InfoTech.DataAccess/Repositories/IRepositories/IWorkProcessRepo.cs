using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IWorkProcessRepo : IRepository<WorkProcess>
    {
        void Update(WorkProcess workProcess);
    }
}
