using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LonghornCinemaReboot.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }

        public virtual List<Movie> Movies { get; set; }
    }
}