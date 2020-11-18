using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "UserName is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "UserName must be 5 to 15 charecters.")]
        public string Username { get; set; }


        [EmailAddress(ErrorMessage = "Please Enter valid Email address.")]
        public string Email { get; set; } //this field is optional


        [Required(ErrorMessage = "Password is required.")]
        [Display(Name = "Password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "password must be 6 to 20 charecters.")]
        [RegularExpression(@"^[a-zA-Z0-9]+$")]
        public string Password { get; set; }



       
        [Required(ErrorMessage = "This field is required.")]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
        public string VarifyPassword { get; set; }

        
    }
}
