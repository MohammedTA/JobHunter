using System;
using System.Collections.Generic;
using System.Text;
using JobHunter.Data.Entities;
using JobHunter.Data.Intefaces;
using JobHunter.Domain.Interfaces;
using JobHunter.Domain.Models.EmployerProfileDomainModel;


namespace JobHunter.Domain.Services
{
   public class EmployerProfileService : IEmployerProfileService
    {
        private readonly IRepository<EmployerProfileDomainModel> _repository;

        public EmployerProfileService(IRepository<EmployerProfileDomainModel> repository)
        {
            _repository = repository;
        }
        public bool SetEmployerProfile (EmployerProfileDomainModel employerProfile)
        {
            _repository.Add(employerProfile);
            if (_repository.Get(p=> p.INN==employerProfile.INN).GetType().GetType().Equals(employerProfile.GetType()))
            return true;
            else return false;
        }
    }
}

