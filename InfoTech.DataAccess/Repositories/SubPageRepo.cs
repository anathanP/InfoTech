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
    public class SubPageRepo : Repository<SubPage>, ISubPageRepo
    {
        private readonly DbSet<SubPage> _dbSet;
        public SubPageRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<SubPage>();
        }

        public void Update(SubPage subPage)
        {
            _dbSet.Update(subPage);
        }
    }
}
