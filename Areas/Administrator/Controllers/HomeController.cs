using Microsoft.AspNetCore.Mvc;

namespace CarDoze.Areas.Administrator.Controllers
{
    public class HomeController : Controller
    {
        [Area("Administrator")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
