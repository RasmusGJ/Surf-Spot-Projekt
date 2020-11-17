using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using surf_spotter_dot_net_core.Models;

namespace surf_spotter_dot_net_core.ViewModels
{
    public class SpotsViewModel
    {
        public List<APIModel.Daily> Daily { get; set; }
        public List<APIModel.Hourly> Hourly { get; set; }
        public List<Spot> Spots { get; set; }
    }
}
