using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Guide.Models
{
    public class Hotel
    {
        [Key]
        public int hotelId { get; set; }

        public string hotelUrl { get; set; }

        public string townName { get; set; }
    }
}