using InfoTech.DataAccess.Repositories.IRepositories;
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
            return View();
        }
    }
}
