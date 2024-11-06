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
        public BrandsSectionViewModel BrandsSectionViewModel { get; set; }
        public ServiceSectionViewModel ServiceSectionViewModel { get; set; }
        public WorkProcessViewModel? WorkProcessViewModel { get; set; }
        public CustomerIndexViewModel(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            HeroBanners = unitOfWork.HeroBanners.GetAllLazyLoad(h => h.Image!).ToList();
            AboutSectionViewModel = new AboutSectionViewModel
            {
                AboutTags = unitOfWork.AboutTags.GetAll().ToList(),
                Phone = unitOfWork.Phones.GetById(1),
                Section = unitOfWork.Sections.Get(s => s.IndexSections == Sd.IndexSections.About),
                ClientCount = 123,
                Image = unitOfWork.Images.GetById(7),
                Video = unitOfWork.Videos.GetById(1)
            };
            BrandsSectionViewModel = new BrandsSectionViewModel
            {
                Brands = unitOfWork.Brands.GetAllLazyLoad(b => b.Image!).ToList(),
                Section = unitOfWork.Sections.Get(s => s.IndexSections == Sd.IndexSections.Brand)
            };
            ServiceSectionViewModel = new ServiceSectionViewModel
            {
                Services = unitOfWork.Services.GetAllLazyLoad(s => s.Image!).ToList(),
                Section = unitOfWork.Sections.Get(s => s.IndexSections == Sd.IndexSections.Service)
            };
            WorkProcessViewModel = new WorkProcessViewModel
            {
                WorkProcesses = unitOfWork.WorkProcess.GetAllLazyLoad(w => w.Image!).ToList(),
                Section = unitOfWork.Sections.Get(s => s.IndexSections == Sd.IndexSections.WorkProcess),
                Image = unitOfWork.Images.GetById(17)
            };
        }
    }
}
