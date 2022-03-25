using System;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class InputViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(9, ErrorMessage = "Password length must be more than 8 characters")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Passwords don't match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(18, 65)]
        public int Age { get; set; }
       
    }
}
