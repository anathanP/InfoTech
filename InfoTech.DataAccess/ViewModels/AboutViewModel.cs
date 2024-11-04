using InfoTech.DataAccess.Repositories.IRepositories;

namespace InfoTech.DataAccess.ViewModels
{
    public class AboutViewModel : CustomerLayoutViewModel
    {
        public AboutViewModel(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
