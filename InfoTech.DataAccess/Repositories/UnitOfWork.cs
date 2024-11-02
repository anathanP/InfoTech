using InfoTech.DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _db;
        public IEmailRepo Emails { get; }

        public UnitOfWork(DbContext db)
        {
            _db = db;
            Emails = new EmailRepo(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
