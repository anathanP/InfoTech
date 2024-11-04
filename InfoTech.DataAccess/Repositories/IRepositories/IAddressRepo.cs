using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IAddressRepo : IRepository<Address>
    {
        void Update(Address address);
    }
}
