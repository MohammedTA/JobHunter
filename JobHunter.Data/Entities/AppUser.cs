using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public bool IsEmployer { get; set; }

        public string Password { get; set; }

        public new byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

    }
}
