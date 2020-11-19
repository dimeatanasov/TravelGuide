using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Guide.Models
{
    public class Restaurant
    {
        [Key]
        public int restoranId { get; set; }

        public string restoranUrl { get; set; }

        public string townName { get; set; }
    }
}