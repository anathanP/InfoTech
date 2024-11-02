using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using InfoTech.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace InfoTech.DataAccess.Repositories
{
    public class EmailRepo : Repository<Email>, IEmailRepo
    {
        private readonly DbSet<Email> _dbSet;
        public EmailRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<Email>();
        }

        public void Update(Email email)
        {
            _dbSet.Update(email);
        }

    }
}
