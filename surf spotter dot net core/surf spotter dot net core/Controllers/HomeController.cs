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
        public async Task<ActionResult> Index()
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
        public async Task<ActionResult<SpotsViewModel>> Spots()
        {
            SpotsViewModel spotsViewModel = new SpotsViewModel();

            var spot = _client.GetOneSpot(3);
            var spots = await _client.GetAllSpots();
            spotsViewModel.Spots = spots;

            var hourly = _client.GetAllByHourly(spot.Result.Lat, spot.Result.Lng);
            spotsViewModel.Hourly = hourly.Result;

            return View(spotsViewModel);
            //return View(await _client.GetAllByHourly(spot.Result.Lat, spot.Result.Lng));
           
        }
        /*[HttpPost, Route("spots")]
        [HttpPost, Route("Home/spots")]
        [HttpPost, Route("S")]
        public async Task<ActionResult> Spots([Bind("Name, Lat, Lng, SpotStatus")] SpotsViewModel spotsViewModel)
        {
            spotsViewModel.Spots = await _client.GetAllSpots();
            if (spotsViewModel.Spots != null)
            {
                List<SelectListItem> selectedItems = spotsViewModel.Spots.Where(p => spotsViewModel.Spots.Contains(p.Id)).ToList();
                foreach (var Tea in selectedItems)
                {
                    Tea.Selected = true;
                    ViewBag.Message += Tea.Text + " | ";
                }
            }
            return View(spotsViewModel);

            return View();
        }*/

        [Route("Privacy")]
        [Route("home/Privacy")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("showspots")]
        public async Task<ActionResult> ShowSpots()
        {

            var spots = await _client.GetAllSpots();

            return View(spots);
        }
    }
}
