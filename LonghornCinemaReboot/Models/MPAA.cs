using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LonghornCinemaReboot.Models
{
    public class MPAA
    {
        public int MPAAID { get; set; }
        public string MPAAName { get; set; }

        public virtual List<Movie> Movies { get; set; }
    }
}