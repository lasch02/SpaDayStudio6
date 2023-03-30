using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "User name is required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "User Name should be between 5-15 characters.")]
        public string? UserName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password should be between 6-20 characters.")]
        [Compare("VerifyPassword", ErrorMessage = "The two passwords must match!")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Verify Password is required")]
        public string? VerifyPassword { get; set; }
    }

}
