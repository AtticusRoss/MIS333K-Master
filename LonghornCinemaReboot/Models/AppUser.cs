using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;


namespace LonghornCinemaReboot.Models
{

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

    //NOTE: This is the class for users
    public class AppUser : IdentityUser
    {

        //First name is here as an example
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [Display(Name = "Address")]
        public String Address { get; set; }

        [Display(Name = "City")]
        public String City { get; set; }

        [Display(Name = "State")]
        public String State { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        [Required(ErrorMessage = "Birthday is required.")]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Popcorn Points")]
        public int PopcornPoints { get; set; }

        [Display(Name = "Customer Number")]
        public int CustomerNumber { get; set; }

        [Display(Name = "Social Security Number")]
        public Int64 SSN { get; set; }

        [Display(Name = "Middle Initial")]
        public String MiddleInitial { get; set; }



        //Orders is here as an example
        public virtual List<Order> Orders { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        public virtual List<Review> Reviews { get; set; }


        //This method allows you to create a new user
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser> manager)
        {
            // NOTE: The authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}