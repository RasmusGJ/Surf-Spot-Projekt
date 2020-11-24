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

        // Regular expression to validate potential spot lookups of lat and lng
        // Lat and Lng to search for spot data
        // Needed in Viewmodel class as Viewmodel is the Model in view
        [Required]
        [RegularExpression("([0-9]+,[0-9]+)", ErrorMessage = "Must be a Latitude format: **,******")]
        public double Lat { get; set; }
        [Required]
        [RegularExpression("([0-9]+,[0-9]+)", ErrorMessage = "Must be in Longtitude format: **,******")]
        public double Lng { get; set; }

        // Lists of model classes to display in view
        public List<APIModel.Daily> Daily { get; set; }
        public List<APIModel.Hourly> Hourly { get; set; }
        public List<Spot> Spots { get; set; }

        // Needed to pass data to controller through view
        // Gets set to the spots Id from Model class which enables api functions
        
        public Comment CurrentComment { get; set; } = new Comment();
    }
}
