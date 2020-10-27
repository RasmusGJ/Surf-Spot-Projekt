using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surf_spotter_dot_net_core.Models
{
    public class Spot
    {
        public List<Spot> Spots { get; set; } = new List<Spot>();
        public long Id  { get; set; }
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int SpotStatus { get; set; }
    }
}
