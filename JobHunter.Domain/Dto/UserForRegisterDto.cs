using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Domain.Dto
{
    public class UserForRegisterDto
    {
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public bool IsEmployer { get; set; }
    }
}
