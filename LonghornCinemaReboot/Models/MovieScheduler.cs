using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LonghornCinemaReboot.Models
{
    public class Day
    {
        [Key]
        public Int32 DateID { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime DayStartTime { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime DayEndTime { get; set; }

        public List<Showing> MoviesTheaterOne { get; set; }
        public List<Showing> MoviesTheaterTwo { get; set; }
    }

    public class Showing
    {
        public int ShowingID { get; set; }

        [Display(Name = "Movie Title")]
        [Required(ErrorMessage = "Movie is required.")]
        public Movie SelectedMovie { get; set; }

        [Column(TypeName = "DateTime2")]
        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Startdate is required.")]
        public DateTime StartTime { get; set; }


        [Display(Name = "Theater ID (1 / 2)")]
        [Required(ErrorMessage = "TheaterID is required")]
        public Int32 TheaterID { get; set; }

        [Display(Name = "Special Event")]
        public bool SpecialEvent { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime EndTime { get; set; }

        public List<Ticket> Tickets { get; set; }

        public Showing()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }

        }


    }
}