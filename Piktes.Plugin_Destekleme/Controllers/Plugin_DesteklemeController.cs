using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Piktes.Plugin_Destekleme.Controllers
{
    public class Plugin_DesteklemeController:Controller
    {

       public IActionResult Index()
        {

            return View();
        }
    }
}
