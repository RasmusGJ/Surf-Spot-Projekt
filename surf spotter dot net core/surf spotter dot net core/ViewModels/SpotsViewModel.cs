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
        [Required]
        [RegularExpression("([0-9]+,[0-9]+)", ErrorMessage = "Must be a Latitude format: **,******")]
        public double Lat { get; set; }
        [Required]
        [RegularExpression("([0-9]+,[0-9]+)", ErrorMessage = "Must be in Longtitude format: **,******")]
        public double Lng { get; set; }
        public List<APIModel.Daily> Daily { get; set; }
        public List<APIModel.Hourly> Hourly { get; set; }
        public List<Spot> Spots { get; set; }
        public int SpotId { get; set; }
    }
}
