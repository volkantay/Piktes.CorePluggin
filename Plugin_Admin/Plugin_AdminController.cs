using Microsoft.AspNetCore.Mvc;

namespace Plugin_Admin
{
    public class Plugin_AdminController : Controller
    {
        public IActionResult Index() => View();
    }
}
