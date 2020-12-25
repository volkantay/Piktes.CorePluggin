using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plugin_User.Controllers
{
    public class Plugin_UserController:Controller
    {

       public IActionResult Index()
        {

            return View();
        }
    }
}
