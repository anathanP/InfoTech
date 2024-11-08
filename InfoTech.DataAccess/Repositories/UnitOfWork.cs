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
        public IAddressRepo Addresses { get; }
        public IWorkTimeRepo WorkTimes { get; }
        public IHeroBannerRepo HeroBanners { get; }
        public ISectionRepo Sections { get; }
        public IAboutTagRepo AboutTags { get; }
        public IVideoRepo Videos { get; }
        public IBrandRepo Brands { get; }
        public IServiceRepo Services { get; }
        public IWorkProcessRepo WorkProcess { get; }
        public IProjectRepo Projects { get; }

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
            Addresses = new AddressRepo(_db);
            WorkTimes = new WorkTimeRepo(_db);
            HeroBanners = new HeroBannerRepo(_db);
            Sections = new SectionRepo(_db);
            AboutTags = new AboutTagRepo(_db);
            Videos = new VideoRepo(_db);
            Brands = new BrandRepo(_db);
            Services = new ServiceRepo(_db);
            WorkProcess = new WorkProcessRepo(_db);
            Projects = new ProjectRepo(_db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
