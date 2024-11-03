using InfoTech.DataAccess.Repositories.IRepositories;
using InfoTech.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InfoTechWeb.Areas.Customer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var model = new TopHeaderViewModel
            {
                Email = _unitOfWork.Emails.GetById(1),
                Phone = _unitOfWork.Phones.GetById(1),
                Languages = _unitOfWork.Languages.GetAll().ToList(),
                SocialMedias = _unitOfWork.SocialMedias.GetAll().ToList()
            };
            return View(model);
        }
    }
}
