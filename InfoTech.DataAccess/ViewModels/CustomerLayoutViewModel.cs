using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Utilities;

namespace InfoTech.DataAccess.ViewModels
{
    public class CustomerLayoutViewModel
    {
        public HeaderViewModel HeaderViewModel{ get; set; }

        public CustomerLayoutViewModel(IUnitOfWork unitOfWork)
        {

            HeaderViewModel = new HeaderViewModel
            {
                Pages = unitOfWork.Pages.GetAllLazyLoad(p => p.SubPages!).ToList(),
                Logo = unitOfWork.Images.GetById(3),
                Theme = Sd.Theme.Light,
                TopHeaderViewModel =  new TopHeaderViewModel
                {
                    Email = unitOfWork.Emails.GetById(1),
                    Phone = unitOfWork.Phones.GetById(1),
                    Languages = unitOfWork.Languages.GetAllLazyLoad(l => l.Image!).ToList(),
                    SocialMedias = unitOfWork.SocialMedias.GetAll().ToList()
                }
            };
        }
    }
}
