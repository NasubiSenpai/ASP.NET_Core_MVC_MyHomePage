using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestProject.Models;


namespace TestProject.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult WelcomePage()
        {
            return View();
        }
    }
}