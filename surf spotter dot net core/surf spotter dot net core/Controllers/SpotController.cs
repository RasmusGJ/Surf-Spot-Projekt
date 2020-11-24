using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using surf_spotter_dot_net_core.Models;
using surf_spotter_dot_net_core.ViewModels;

namespace surf_spotter_dot_net_core.Controllers
{
    public class SpotController : Controller
    {
        private readonly ILogger<SpotController> _logger;
        private readonly IdentityDataContext _db;
        private readonly HttpProxy _client;

        public SpotController(ILogger<SpotController> logger, IdentityDataContext db, HttpProxy client)
        {
            _logger = logger;
            _db = db;
            _client = client;
        }

        [HttpGet, Route("spots")]
        [HttpGet, Route("s")]
        //[HttpGet, Route("")]
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

        [HttpPost, Route("spots")]
        [HttpPost, Route("s")]
        //[HttpPost, Route("")]
        public async Task<ActionResult> Spots(SpotsViewModel spotsViewModel)
        {
            var spots = await _client.GetAllSpots();
            spotsViewModel.Spots = spots;
            foreach (Spot s in spotsViewModel.Spots)
            {
                if (s.Id == spotsViewModel.SpotId)
                {
                    var daily = await _client.GetAllByDaily(s.Lat, s.Lng);
                    spotsViewModel.Daily = daily;
                    break;
                }
            }

            return View(spotsViewModel);
        }

        [Route("CreateSpot")]
        [Route("CS")]
        //[Route("")]
        [HttpGet]
        public IActionResult CreateSpot()
        {
            return View();
        }

        [HttpPost, Route("CreateSpot")]
        [HttpPost, Route("CS")]
        //[HttpPost, Route("")]
        public IActionResult CreateSpot([Bind("Name, Lat, Lng, SpotStatus")] Spot spot)
        {
            if (!ModelState.IsValid)
                return View();

            _db.Spots.Add(spot);
            _db.SaveChanges();
            return View();
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