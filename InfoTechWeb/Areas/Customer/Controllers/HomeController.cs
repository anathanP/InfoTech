using Microsoft.AspNetCore.Mvc;

namespace InfoTechWeb.Areas.Customer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
