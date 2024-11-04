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

        void Save();
    }
}
