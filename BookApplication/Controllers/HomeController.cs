using Microsoft.AspNetCore.Mvc;

namespace BookApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
