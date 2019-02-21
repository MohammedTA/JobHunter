using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Presentation.ViewModels
{
    public class WokerProfileViewModel
    {
        [Required(ErrorMessage = "Surname is required")]
        [StringLength(255, ErrorMessage = "Surname must be between 1 and 255 character", MinimumLength = 1)]
        public string surname { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(255, ErrorMessage = "Name must be between 1 and 255 character", MinimumLength = 1)]
        public string name { get; set; }
        [Required(ErrorMessage = "Middlename is required")]
        [StringLength(255, ErrorMessage = "Middlename must be between 1 and 255 character", MinimumLength = 1)]
        public string middlename { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [StringLength(255, ErrorMessage = "Password must be between 8 and 255 character", MinimumLength = 1)]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage ="Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage ="Compare password not equal password")]
        public string confirm_password { get; set; }
        [Required]
        public virtual ContactsViewModel contacts { get; set; }
    }
}
