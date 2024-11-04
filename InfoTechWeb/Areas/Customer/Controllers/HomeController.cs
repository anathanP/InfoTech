using InfoTech.DataAccess.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using InfoTech.DataAccess.ViewModels;

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
            var model = new CustomerIndexViewModel(_unitOfWork);
            return View(model);
        }

        public IActionResult About()
        {
            var model = new AboutViewModel(_unitOfWork);
            return View(model);
        }
    }
}
