using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class LoginViewModel
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use latin letters only please")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
