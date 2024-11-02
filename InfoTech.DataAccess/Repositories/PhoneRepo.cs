using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    internal class PhoneRepo : Repository<Phone>, IPhoneRepo
    {
        private readonly DbSet<Phone> _dbSet;
        public PhoneRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<Phone>();
        }

        public void Update(Phone phone)
        {
            _dbSet.Update(phone);
        }
    }
}
