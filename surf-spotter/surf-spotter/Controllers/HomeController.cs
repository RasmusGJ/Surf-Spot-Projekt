using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using surf_spotter.Models;

namespace surf_spotter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        [Route("H")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Aboutus")]
        [Route("home/Aboutus")]
        [Route("AU")]
        public IActionResult Aboutus()
        {
            return View();
        }

        [Route("Kontakt")]
        [Route("home/Kontakt")]
        [Route("K")]
        public IActionResult Kontakt()
        {
            return View();
        }

        
        [Route("Signup")]
        [Route("Home/Signup")]
        [Route("SU")]
        public IActionResult Signup()
        {
            return View();
        }

        
        [Route("login")]
        [Route("Home/login")]
        [Route("L")]
        public IActionResult login()
        {
            return View();
        }

        
        [Route("spots")]
        [Route("Home/spots")]
        [Route("S")]
        public IActionResult spots()
        {
            return View();
        }

        [Route("Privacy")]
        [Route("home/Privacy")]
        public IActionResult Privacy()
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
