using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JobHunter.Domain.Models.EmployerProfileDomainModel;

namespace JobHunter.Domain.Interfaces
{
    public interface IEmployerProfileService
    {
         bool SetEmployerProfile(EmployerProfileDomainModel model);
    }
}