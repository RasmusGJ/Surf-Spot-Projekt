using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using surf_spotter_dot_net_core.Models;
using System.ComponentModel.DataAnnotations;

namespace surf_spotter_dot_net_core.ViewModels
{
    public class SpotsViewModel
    {
        // Needed in Viewmodel class as Viewmodel is the Model in view
        public Spot CurrentSpot { get; set; } = new Spot();

        // Lists of model classes to display in view
        public List<APIModel.Daily> Daily { get; set; }
        public List<APIModel.Hourly> Hourly { get; set; }
        public List<Spot> Spots { get; set; }

        //Sets the specified data format(metric, imperial etc.)
        public int SpotFormat { get; set; }
    }
}
