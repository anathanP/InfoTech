namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        IEmailRepo Emails { get; }
        IPhoneRepo Phones { get; }


        void Save();
    }
}
