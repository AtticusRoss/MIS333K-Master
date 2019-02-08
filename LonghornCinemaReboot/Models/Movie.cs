using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LonghornCinemaReboot.Models
{

    public class Movie
    {
        public Int32 MovieID { get; set; }

        [Display(Name = "Movie Number")]
        public int MovieNumber { get; set; }
        
        [Required(ErrorMessage = "Movie title required")]
        [Display(Name = "Movie Title")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Overview required")]
        [Display(Name = "Overview")]
        public String Overview { get; set; }

        [Required(ErrorMessage = "Actor required")]
        [Display(Name = "Actors")]
        public String Actors { get; set; }

        [Display(Name = "Tagline")]
        public String Tagline { get; set; }

        [Column(TypeName = "DateTime2")]
        [Required(ErrorMessage = "Movie release date required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }


        [Display(Name = "Customer Rating")]
        public Decimal CustomerRating
        {
            get
            {
                if (Reviews.Count() != 0)
                {
                    return Reviews.Average(r => r.CustRating);
                }
                else
                {
                    return 0.0M;
                }
            }
        }
        
        [Display(Name = "Revenue")]
        public Int64 Revenue { get; set; }

        [Required(ErrorMessage = "Run time required")]
        [Display(Name = "Running Time")]
        public Int32 RunTime { get; set; }

        public virtual List<Showing> Showings { get; set; }
        public virtual List<Genre> Genres { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual MPAA MPAA { get; set; }

        public Movie()
        {
            if (Showings == null)
            {
                Showings = new List<Showing>();
            }

            if (Genres == null)
            {
                Genres = new List<Genre>();
            }

            if (Reviews == null)
            {
                Reviews = new List<Review>();
            }

        }
    }
}