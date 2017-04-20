using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgrammingFinal.Model
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }
        [StringLength(55), Required(ErrorMessage = "First name is required.")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [StringLength(55), Required(ErrorMessage = "Last name is required.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [StringLength(120), Required(ErrorMessage = "Email address is required.")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [StringLength(25), Required(ErrorMessage = "Username is required.")]
        //  Not sure if i can get this working, but got duplications validated in code anyway.
        // [Remote("doesUserNameExist", "Account", HttpMethod = "POST", ErrorMessage = "User name already exists. Please enter a different user name.")]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        [RegularExpression("^([a-zA-Z0-9@*#]{8,25})$", ErrorMessage = "Password format invalid.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

        

        // Other properties and the validation for them.
    }
}
