using Microsoft.AspNetCore.Mvc;

namespace Piktes.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
