using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JobHunter.Data.Entities;
using JobHunter.Data.Intefaces;
using JobHunter.Domain.Helpers;
using JobHunter.Domain.Interfaces;
using JobHunter.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace JobHunter.Domain.Services
{
    public class AuthService : IAuthService
    {
        private readonly IRepository<User> _repository;
        private readonly IConfiguration _config;
        private readonly UserManager<User> _userManager;
        private readonly FacebookAuthSettings _fbAuthSettings;
        private static readonly HttpClient Client = new HttpClient();

        public AuthService(IRepository<User> repository,
                           IConfiguration config,
                           UserManager<User> userManager,
                           IOptions<FacebookAuthSettings> fbAuthSettingsAccessor)
        {
            _config = config;
            _userManager = userManager;
            _repository = repository;
            _fbAuthSettings = fbAuthSettingsAccessor.Value;
        }

        public async Task<string> Login(UserForLoginDto userForLogin)
        {
            userForLogin.Email = userForLogin.Email.ToLower();

            var userToVerify = await _userManager.FindByEmailAsync(userForLogin.Email);

            if (userToVerify == null)
                return null;

            if (!await _userManager.CheckPasswordAsync(userToVerify, userForLogin.Password))
                return null;

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userToVerify.Id.ToString()),
                new Claim(ClaimTypes.Name, userToVerify.Email)
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

            return tokenToReturn;
        }

        public async Task<string> LoginWithFacebook(string accessToken)
        {
            // 1.generate an app access token
            var appAccessTokenResponse = await Client.GetStringAsync($"https://graph.facebook.com/oauth/access_token?client_id={_fbAuthSettings.AppId}&client_secret={_fbAuthSettings.AppSecret}&grant_type=client_credentials");
            var appAccessToken = JsonConvert.DeserializeObject<FacebookAppAccessToken>(appAccessTokenResponse);

            // 2. validate the user access token
            var userAccessTokenValidationResponse = await Client.GetStringAsync($"https://graph.facebook.com/debug_token?input_token={accessToken}&access_token={appAccessToken.AccessToken}");
            var userAccessTokenValidation = JsonConvert.DeserializeObject<FacebookUserAccessTokenValidation>(userAccessTokenValidationResponse);

            if (!userAccessTokenValidation.Data.IsValid)
              return null;

            // 3. we've got a valid token so we can request user data from fb
            var userInfoResponse = await Client.GetStringAsync($"https://graph.facebook.com/v2.8/me?fields=id,email&access_token={accessToken}");
            var userInfo = JsonConvert.DeserializeObject<FacebookUserData>(userInfoResponse);

            var userToVerify = await _userManager.FindByNameAsync(userInfo.Email);

            if (userToVerify == null)
                return null;

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userToVerify.Id.ToString()),
                new Claim(ClaimTypes.Name, userToVerify.Email)
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

            return tokenToReturn;
        }
    }
}