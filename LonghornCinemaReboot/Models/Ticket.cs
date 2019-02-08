using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornCinemaReboot.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }

        [Display(Name = "Ticket Price")]
        //[Required(ErrorMessage ="Must specify price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TicketPrice { get; set; }

        //[Required(ErrorMessage = "You must specify a seat")]
        public String Seat { get; set; }

        //[Required(ErrorMessage = "Is this seat taken?")]
        public bool Taken { get; set; }

        public virtual Order Order { get; set; }
        public virtual Showing Showing { get; set; }

    }
}