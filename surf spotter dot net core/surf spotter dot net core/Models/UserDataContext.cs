using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace surf_spotter_dot_net_core.Models
{
    //Klasse for at bruge EF database
    public class UserDataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Spot> Spots { get; set; }

        public UserDataContext(DbContextOptions<UserDataContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
