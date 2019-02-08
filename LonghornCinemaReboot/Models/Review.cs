using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornCinemaReboot.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        [Required(ErrorMessage ="Rating is required")]
        [Display(Name ="Stars")]
        [Range(1,5,ErrorMessage ="Quantity must be between 1 and 5")]
        public decimal CustRating { get; set; }

        [StringLength(100)]
        [Display(Name = "Review")]
        public string TextReview { get; set; }

        public Int32 Votes { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual AppUser AppUser { get; set; }
    }
}