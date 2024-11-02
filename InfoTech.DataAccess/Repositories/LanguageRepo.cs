using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoTech.DataAccess.Repositories
{
    internal class LanguageRepo : Repository<Language>, ILanguageRepo

    {
        private readonly DbSet<Language> _dbSet;
        public LanguageRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<Language>();
        }

        public void Update(Language language)
        {
            _dbSet.Update(language);
        }
    }
}
