using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace LonghornCinemaReboot.Models
{
   
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {


        //Additional fields go here (First name is an example)
        //Remember, there is already a field for email, phone number, and password
        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }


        //NOTE: Here is the property for email
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //NOTE: Here is the property for phone number
        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [Display(Name = "Address")]
        public String Address { get; set; }

        [Required(ErrorMessage = "Birthday is required.")]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        //NOTE: Here is the logic for putting in a password
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }   

    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public String UserName { get; set; }
        [Display(Name = "Email")]
        public String Email { get; set; }
        public String UserID { get; set; }
        public String PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public String Address { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class InfoViewModel
    {
        public String Email { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public String Address { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Display(Name = "New Phone Number")]
        public String NewPhoneNumber { get; set; }

        [Display(Name = "New Address")]
        public String NewAddress { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "New Birthday")]
        public DateTime NewBirthday { get; set; }
    }
    public class CreditCardViewModel
    {

        [DataType(DataType.CreditCard)]
        [CreditCard]
        [Display(Name = "Credit Card One")]
        public String CreditCardOne { get; set; }

        [Display(Name = "Credit Card One CV2")]
        public String CV2One { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Credit Card One Date")]
        public DateTime DateOne { get; set; }

        [Display(Name = "Credit Card One Type")]
        public String CreditCardTypeOne { get; set; }

        [DataType(DataType.CreditCard)]
        [CreditCard]
        
        [Display(Name = "Credit Card Two")]
        public String CreditCardTwo { get; set; }

        [Display(Name = "Credit Card Two CV2")]
        public String CV2Two { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Credit Card Two Date")]
        public DateTime DateTwo { get; set; }

        [Display(Name = "Credit Card Two Type")]
        public String CreditCardTypeTwo { get; set; }

    }
    public class OrderViewModel
    {
        public String Email { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public String Address { get; set; }

        public List<Order> UserOrders { get; set; }


    }
}
