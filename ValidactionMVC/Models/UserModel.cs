using System.ComponentModel.DataAnnotations;

namespace ValidactionMVC.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Username is required")]
        [RegularExpression(@"^[a-zA-Z0-9]{5,12}$", ErrorMessage = "Username must be 5-12 characters and contain only letters and numbers")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Password must be minimum 8 characters, at least one letter and one number")]
        public string Password { get; set; }
    }
}
