namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        IEmailRepo Emails { get; }
        IPhoneRepo Phones { get; }
        ILanguageRepo Languages { get; }
        IImageRepo Images { get; }


        void Save();
    }
}
