using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LonghornCinemaReboot.Models
{
    public class Order
    {
        private const Decimal SALES_TAX_RATE = 0.0825m;

        [Key]
        public int OrderID { get; set; }

        [Display(Name = "Order Number")]
        public int OrderNumber { get; set; }

        [Column(TypeName = "DateTime2")]
        [Display(Name = "Order Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Order Notes")]
        public string Notes { get; set; }

        [Display(Name = "Order Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            get { return Tickets.Sum(rd => rd.TicketPrice); }
        }

        [Display(Name = "Sales Tax (8.25%)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SalesTax
        {
            get { return OrderSubtotal * SALES_TAX_RATE; }
        }

        [Display(Name = "Registration Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + SalesTax; }
        }

        public virtual AppUser AppUser { get; set; }

        public virtual List<Ticket> Tickets { get; set; }

        public Order()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }
        }
    }
}