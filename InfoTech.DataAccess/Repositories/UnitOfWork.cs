using InfoTech.DataAccess.Data;
using InfoTech.DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;
        public IEmailRepo Emails { get; }
        public IPhoneRepo Phones { get; set; }

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            Emails = new EmailRepo(_db);
            Phones = new PhoneRepo(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
