using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Travel_Guide.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=DefaultConnection")
        {
        }   

        public DbSet<TravelGuide> travelGuides { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}