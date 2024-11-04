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
    internal class AddressRepo : Repository<Address>, IAddressRepo
    {
        private readonly DbSet<Address> _dbSet;
        public AddressRepo(DbContext db) : base(db)
        {
            _dbSet = db.Set<Address>();
        }

        public void Update(Address address)
        {
            _dbSet.Update(address);
        }
    }
}
