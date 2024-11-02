namespace InfoTech.DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        IEmailRepo Emails { get; }


        void Save();
    }
}
