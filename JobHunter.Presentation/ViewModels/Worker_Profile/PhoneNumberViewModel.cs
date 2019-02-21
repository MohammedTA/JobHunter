using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Presentation.ViewModels.Worker_Profile
{
    public class PhoneNumberViewModel
    {
        [DataType(DataType.PhoneNumber, ErrorMessage = "Wrong format of phone number")]  
        public string Phone { get; set; }
    }
}
