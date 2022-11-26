using System;
using Microsoft.AspNetCore.Mvc;

namespace TestProject.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string _name,int _age = 0)
        {
            return $"{_name}san{_age}sai";
        }

    }
}
