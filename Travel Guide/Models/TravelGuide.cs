using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Guide.Models
{
    public class TravelGuide
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public string backgroundPicture { get; set; }

        public List<Gallery> galleries { get; set; }

        public List<Restaurant> restaurants { get; set; }

        public List<Hotel> hotels { get; set; }
    }
}