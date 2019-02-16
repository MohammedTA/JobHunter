using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JobHunter.Domain.Dto;

namespace JobHunter.Domain.Interfaces
{
    public interface IUserService
    {
        Task<UserForReturnDto> GetUser(int id);
    }
}
