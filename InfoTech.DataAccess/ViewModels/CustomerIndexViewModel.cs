using System.Security.AccessControl;
using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models;
using InfoTech.Utilities;

namespace InfoTech.DataAccess.ViewModels
{
    public class CustomerIndexViewModel : CustomerLayoutViewModel
    {
        public List<HeroBanner> HeroBanners { get; set; }
        public AboutSectionViewModel AboutSectionViewModel { get; set; }
        public CustomerIndexViewModel(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            HeroBanners = unitOfWork.HeroBanners.GetAllLazyLoad(h => h.Image!).ToList();
            AboutSectionViewModel = new AboutSectionViewModel
            {
                AboutTags = unitOfWork.AboutTags.GetAll().ToList(),
                Phone = unitOfWork.Phones.GetById(1),
                Section = unitOfWork.Sections.Get(s => s.IndexSections == Sd.IndexSections.About),
                ClientCount = 123
            };
        }
    }
}
