using InfoTech.DataAccess.Data;
using InfoTech.DataAccess.Repositories.IRepositories;

namespace InfoTech.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;
        public IEmailRepo Emails { get; }
        public IPhoneRepo Phones { get; }
        public ILanguageRepo Languages { get; }
        public IImageRepo Images { get; }
        public ISocialMediaRepo SocialMedias { get; }
        public IPageRepo Pages { get; }
        public ISubPageRepo SubPages { get; }

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            Emails = new EmailRepo(_db);
            Phones = new PhoneRepo(_db);
            Languages = new LanguageRepo(_db);
            Images = new ImageRepo(_db);
            SocialMedias = new SocialMediaRepo(_db);
            Pages = new PageRepo(_db);
            SubPages = new SubPageRepo(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
