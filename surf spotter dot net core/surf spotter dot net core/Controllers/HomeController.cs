using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using surf_spotter_dot_net_core.Models;

namespace surf_spotter_dot_net_core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserDataContext _dbUser;
        

        public HomeController(ILogger<HomeController> logger, UserDataContext dbUser)
        {
            _logger = logger;
            _dbUser = dbUser;
            

        }
        [Route("")]
        [Route("Index")]
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

        [HttpGet, Route("Kontakt")]
        [HttpGet, Route("home/Kontakt")]
        [HttpGet, Route("K")]
        public IActionResult Kontakt()
        {
            return View();
        }


        //Metode til rent faktisk at registere

        [HttpPost, Route("Signup")]
        [HttpPost, Route("Home/Signup")]
        [HttpPost, Route("SU")]
        public IActionResult Signup([Bind("UserName, Email, Password")] User user)
        {

            if (!ModelState.IsValid)
                return View();


            _dbUser.Users.Add(user);
            _dbUser.SaveChanges();
            return View();
        }

        [Route("showusers")]
        public IActionResult ShowUsers()
        {
            var users = _dbUser.Users.ToArray();
            ViewBag.Users = users;
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

        [HttpPost, Route("CreateSpot")]
        [HttpPost, Route("Home/CreateSpot")]
        [HttpPost, Route("CS")]
        public IActionResult CreateSpot([Bind("Name, Lat, Lng, SpotStatus")] Spot spot)
        {

            if (!ModelState.IsValid)
                return View();


            _dbUser.Spots.Add(spot);
            _dbUser.SaveChanges();
            return View();
        }
        [HttpGet, Route("CreateSpot")]
        [HttpGet, Route("Home/CreateSpot")]
        [HttpGet, Route("CS")]
        public IActionResult CreateSpot()
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
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
