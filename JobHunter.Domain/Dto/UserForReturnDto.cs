using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Domain.Dto
{
    public class UserForReturnDto
    {
        public string Email { get; set; }

        public bool IsEmployer { get; set; }
    }
}
