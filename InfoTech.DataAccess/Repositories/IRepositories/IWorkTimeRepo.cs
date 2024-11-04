using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IWorkTimeRepo : IRepository<WorkTime>
    {
        void Update(WorkTime entity);
    }
}
