using InfoTech.DataAccess.Repositories.IRepositories;

namespace InfoTech.DataAccess.ViewModels
{
    public class CustomerIndexViewModel : CustomerLayoutViewModel
    {
        public CustomerIndexViewModel(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
