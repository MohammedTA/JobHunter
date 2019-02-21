using Castle.Core.Configuration;
using JobHunter.Data.Entities;
using JobHunter.Data.Intefaces;
using JobHunter.Data.Repository;
using JobHunter.Domain.Interfaces;
using JobHunter.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Domain.Services
{
    public class WorkerProfileService : IWorkerProfileService
    {
        private readonly IRepository<Profile> _repository;

        public WorkerProfileService(IRepository<Profile> repository)
        {
            _repository = repository;
        }
        public int CreateInfoProfile(WorkerProfileDTO workerProfile)
        {
            var phones = new List<PhoneNumber>();
            phones.Add(new PhoneNumber() { IsMain = true, Number = workerProfile.Contacts.Phones[0].Phone });
            if (workerProfile.Contacts.Phones.Count > 1)
            {
                for (int i = 1; i < workerProfile.Contacts.Phones.Count; i++)
                {
                    phones.Add(new PhoneNumber() { IsMain = false, Number = workerProfile.Contacts.Phones[i].Phone });
                }
            }
            try
            {
                Profile profile = new Profile()
                {
                    SurName = workerProfile.Surname,
                    Name = workerProfile.Name,
                    MiddleName = workerProfile.Middlename,
                    PhoneNumbers = new List<PhoneNumber>(phones),
                    Messengers = new List<Messenger>()
                    {
                        new Messenger(){ Number=workerProfile.Contacts.Skype, Type="Skype"},
                        new Messenger(){ Number=workerProfile.Contacts.Viber, Type="Viber"},
                        new Messenger(){ Number=workerProfile.Contacts.Telegram, Type="Telegram"},
                        new Messenger(){ Number=workerProfile.Contacts.Whats_up, Type="Whats_up"}
                    }
                };
                _repository.Add(profile);
                return profile.Id;
            }
            catch
            {
                return -1;
            }
        }
    }
}
