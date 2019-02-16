using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using JobHunter.Data.Entities;
using JobHunter.Data.Interfaces;
using JobHunter.Domain.Dto;
using JobHunter.Domain.Interfaces;

namespace TestSSProject.Domain.Services
{
    public class AuthService : IAuthService
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IConfiguration _config;

        public AuthService(IRepository<AppUser> repository, IConfiguration config)
        {
            _config = config;
            _repository = repository;
        }

        public UserForReturnDto Register(UserForRegisterDto userForRegister)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(userForRegister.Password, out passwordHash, out passwordSalt);
            userForRegister.PasswordHash = passwordHash;
            userForRegister.PasswordSalt = passwordSalt;

            userForRegister.Email = userForRegister.Email.ToLower();

            var userToCreate = Mapper.Map<AppUser>(userForRegister);

            var userCreated = _repository.Create(userToCreate);

            var userToReturn = Mapper.Map<UserForReturnDto>(userCreated);

            return userToReturn;
        }

        public async Task<string> Login(UserForLoginDto userForLogin)
        {
            userForLogin.Email = userForLogin.Email.ToLower();

            var userFromRepo = await _repository.Get(e => e.Email == userForLogin.Email);

            if (!VerifyPasswordHash(userForLogin.Password, userFromRepo.PasswordHash, userFromRepo.PasswordSalt))
                return null;

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userFromRepo.Id.ToString()),
                new Claim(ClaimTypes.Name, userFromRepo.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            var tokenToReturn = tokenHandler.WriteToken(token);

            // var user = _mapper.Map<UserForListDto>(userFromRepo);

            // return Ok(new
            // {
            //     token = tokenHandler.WriteToken(token),
            //     user
            // });

            return tokenToReturn;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
            }
            return true;
        }

        public async Task<bool> UserExists(string email, string phoneNumber)
        {
            if (await _repository.Get(e => e.Email == email) != null)
                return true;

            return false;
        }
    }
}