namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        IEmailRepo Emails { get; }
        IPhoneRepo Phones { get; }
        ILanguageRepo Languages { get; }


        void Save();
    }
}
