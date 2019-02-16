using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JobHunter.Domain.Dto;

namespace JobHunter.Domain.Interfaces
{
    
        public interface IAuthService
        {
            UserForReturnDto Register(UserForRegisterDto userForRegister);

            Task<bool> UserExists(string email, string password);

            Task<string> Login(UserForLoginDto userForLogin);
        }
    
}
