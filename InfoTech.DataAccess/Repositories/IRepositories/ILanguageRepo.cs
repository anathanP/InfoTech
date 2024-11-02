using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface ILanguageRepo : IRepository<Language>
    {
        void Update(Language language);
    }
}
