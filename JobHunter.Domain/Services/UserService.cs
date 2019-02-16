using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using JobHunter.Data.Entities;
using JobHunter.Data.Interfaces;
using JobHunter.Domain.Dto;
using JobHunter.Domain.Interfaces;

namespace JobHunter.Domain.Services
{
    public class UserService:IUserService
    {
        private readonly IRepository<AppUser> _repository;

        public UserService(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task<UserForReturnDto> GetUser(int id)
        {
            var user = await _repository.Get(u => u.Id == id);

            return Mapper.Map<UserForReturnDto>(user);
        }

    }
}
