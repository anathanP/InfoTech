namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        IEmailRepo Emails { get; }
        IPhoneRepo Phones { get; }
        ILanguageRepo Languages { get; }
        IImageRepo Images { get; }
        ISocialMediaRepo SocialMedias { get; }
        IPageRepo Pages { get; }
        ISubPageRepo SubPages { get; }
        IAddressRepo Addresses { get; }
        IWorkTimeRepo WorkTimes { get; }
        IHeroBannerRepo HeroBanners { get; }
        ISectionRepo Sections { get; }
        IAboutTagRepo AboutTags { get; }
        IVideoRepo Videos { get; }
        IBrandRepo Brands { get; }
        IServiceRepo Services { get; }
        void Save();
    }
}
