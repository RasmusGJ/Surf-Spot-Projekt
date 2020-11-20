using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using surf_spotter_dot_net_core.Models;
using surf_spotter_dot_net_core.ViewModels;
using System.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Entity.Infrastructure;

namespace surf_spotter_dot_net_core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IdentityDataContext _db;
        private readonly HttpProxy _client;

        public HomeController(ILogger<HomeController> logger, IdentityDataContext db, HttpProxy client)
        {
            _logger = logger;
            _db = db;
            _client = client;
        }

        [Route("")]
        [Route("Index")]
        [Route("H")]
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View();
        }

        [Route("Aboutus")]
        [Route("home/Aboutus")]
        [Route("AU")]
        [HttpGet]
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
        [HttpGet]
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

        [HttpGet, Route("spots")]
        [HttpGet, Route("Home/spots")]
        [HttpGet, Route("s")]
        public async Task<ActionResult<SpotsViewModel>> Spots()
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            SpotsViewModel spotsViewModel = new SpotsViewModel();

            var spot = _client.GetOneSpot(2);
            var spots = await _client.GetAllSpots();
            spotsViewModel.Spots = spots;

            //var hourly = await _client.GetAllByHourly(spot.Result.Lat, spot.Result.Lng);
            //spotsViewModel.Hourly = hourly;

            var daily = await _client.GetAllByDaily(spot.Result.Lat, spot.Result.Lng);
            spotsViewModel.Daily = daily;

            return View(spotsViewModel);
        }


        [HttpPost, Route("s")]
        [HttpPost, Route("spots")]
        [HttpPost, Route("Home/spots")]
        public async Task<ActionResult> Spots(SpotsViewModel spotsViewModel)
        {
            var spots = await _client.GetAllSpots();
            spotsViewModel.Spots = spots;
            foreach (Spot s in spotsViewModel.Spots)
            {
                if(s.Id == spotsViewModel.SpotId)
                {
                    var daily = await _client.GetAllByDaily(s.Lat, s.Lng);
                    spotsViewModel.Daily = daily;
                    break;
                }                               
            }
           
            return View(spotsViewModel);
        }

        [Route("Privacy")]
        [Route("home/Privacy")]
        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("showspots")]
        [HttpGet]
        public async Task<ActionResult> ShowSpots()
        {

            var spots = await _client.GetAllSpots();

            return View(spots);
        }

        [Route("editspot")]
        [Route("Home/editspot")]
        [HttpGet]
        public async Task<ActionResult> EditSpot()
        {
            var spot = await _client.GetOneSpot(1);
            return View(spot);
        }

        [Route("editspot")]
        [Route("Home/editspot")]
        [HttpPost]
        public IActionResult EditSpot(Spot spot)
        {
            return View();
        }
    }
}
