using System.Security.AccessControl;
using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;

namespace InfoTech.DataAccess.ViewModels
{
    public class CustomerIndexViewModel : CustomerLayoutViewModel
    {
        public List<HeroBanner> HeroBanners { get; set; }
        public CustomerIndexViewModel(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            HeroBanners = unitOfWork.HeroBanners.GetAllLazyLoad(h => h.Image!).ToList();
        }
    }
}
