﻿using InfoTech.Models;

namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface ILanguageRepo : IRepository<Language>
    {
        void Update(Language language);
    }
}
