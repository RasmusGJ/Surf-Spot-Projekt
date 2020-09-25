using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace surf_spotter_dot_net_core.Models
{
    public class SpotDataContext : DbContext
    {
        public DbSet<Spot> Spots { get; set; }

        public SpotDataContext(DbContextOptions<SpotDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}