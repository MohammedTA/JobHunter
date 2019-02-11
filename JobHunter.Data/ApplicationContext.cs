using JobHunter.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Data
{
    public class ApplicationContext : IdentityDbContext<User, IdentityRole<int>,int>
    {

    }
}
