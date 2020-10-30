using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using surf_spotter_dot_net_core.Models;

namespace surf_spotter_dot_net_core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IdentityDataContext _db;

        public HomeController(ILogger<HomeController> logger, IdentityDataContext db)
        {
            _logger = logger;
            _db = db;
        }

        [Route("")]
        [Route("Index")]
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

        [Route("CreateSpot")]
        [Route("Home/CreateSpot")]
        [Route("CS")]
        public IActionResult CreateSpot()
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

            _db.Spots.Add(spot);
            _db.SaveChanges();
            return View();
        }       

        [Route("spots")]
        [Route("Home/spots")]
        [Route("S")]
        public IActionResult Spots()
        {
            Spot spot = new Spot();
            foreach (Spot s in _db.Spots)
            {
                spot.Spots.Add(s);
            }
            return View(spot.Spots);
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
