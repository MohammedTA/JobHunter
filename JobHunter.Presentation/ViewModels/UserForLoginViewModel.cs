using System.ComponentModel.DataAnnotations;

namespace JobHunter.Presentation.ViewModels
{
    public class UserForLoginViewModel
    {
        [Required]
        public string Input { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "You must specify password between 6 and 12 characters")]
        public string Password { get; set; }
    }
}