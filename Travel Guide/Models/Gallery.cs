using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel_Guide.Models
{
    public class Gallery
    {
        [Key]
        public int pictureId { get; set; }

        public string pictureUrl { get; set; }

        public string townName { get; set; }
    }
}