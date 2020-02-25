using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Garant.Models;

namespace Garant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult comments()
        {
            return View();
        }
        public IActionResult ErrorFindOfPage()
        {
            return View();
        }

        public IActionResult contact()
        {
            return View();
        }

        public IActionResult help()
        {
            return View();
        }
        public IActionResult join()
        {
            return View();
        }

        public IActionResult static2()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View(); 
        }
        public IActionResult staticpage()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
