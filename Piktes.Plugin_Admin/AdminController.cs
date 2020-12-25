using Microsoft.AspNetCore.Mvc;
using System;

namespace Piktes.Plugin_Admin
{
    public class AdminController : Controller
    {
        public IActionResult Index() => View();
    }
}
