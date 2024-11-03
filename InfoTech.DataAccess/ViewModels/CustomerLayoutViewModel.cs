using InfoTech.DataAccess.Repositories.IRepositories;

namespace InfoTech.DataAccess.ViewModels
{
    public class CustomerLayoutViewModel
    {
        public TopHeaderViewModel TopHeaderViewModel { get; set; }

        public CustomerLayoutViewModel(IUnitOfWork unitOfWork)
        {
            TopHeaderViewModel = new TopHeaderViewModel
            {
                Email = unitOfWork.Emails.GetById(1),
                Phone = unitOfWork.Phones.GetById(1),
                Languages = unitOfWork.Languages.GetAll().ToList(),
                SocialMedias = unitOfWork.SocialMedias.GetAll().ToList()
            };
        }
    }
}
