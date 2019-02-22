using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
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
        public string TokenToReturn;
        private readonly IRepository<User> _repository;
        private readonly IJwtFactory _jwtFactory;
        private readonly UserManager<User> _userManager;
        private readonly FacebookAuthSettings _fbAuthSettings;
        private static readonly HttpClient Client = new HttpClient();
        private User currentUser;

        public AuthService(UserManager<User> userManager,
                           IOptions<FacebookAuthSettings> fbAuthSettingsAccessor,
                           IRepository<User> repository,
                           IJwtFactory jwtFactory)
        {
            _userManager = userManager;
            _fbAuthSettings = fbAuthSettingsAccessor.Value;
            _repository = repository;
            _jwtFactory = jwtFactory;
        }

        public async Task<string> Login(UserForLoginDto userForLogin)
        {
            userForLogin.Input = userForLogin.Input.ToLower();

            var userToVerifyEmail = await _userManager.FindByEmailAsync(userForLogin.Input);

            if (userToVerifyEmail != null)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userToVerifyEmail.Id.ToString()),
                    new Claim(ClaimTypes.Name, userToVerifyEmail.Email)
                };

                TokenToReturn = _jwtFactory.GenerateEncodedToken(claims);

                currentUser = userToVerifyEmail;
            }
            
            var userToVerifyPhone = _repository.GetSingle(p => p.PhoneNumber == userForLogin.Input);

            if (userToVerifyPhone != null)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userToVerifyPhone.Id.ToString()),
                    new Claim(ClaimTypes.Name, userToVerifyPhone.PhoneNumber)
                };

                TokenToReturn = _jwtFactory.GenerateEncodedToken(claims);

                currentUser = userToVerifyPhone;
            }

            if (!await _userManager.CheckPasswordAsync(currentUser, userForLogin.Password))
                return null;

            return TokenToReturn;
        }

        public async Task<string> LoginWithFacebook(string accessToken)
        {
            var appAccessTokenResponse = await Client.GetStringAsync($"https://graph.facebook.com/oauth/access_token?client_id={_fbAuthSettings.AppId}&client_secret={_fbAuthSettings.AppSecret}&grant_type=client_credentials");
            var appAccessToken = JsonConvert.DeserializeObject<FacebookAppAccessToken>(appAccessTokenResponse);

            var userAccessTokenValidationResponse = await Client.GetStringAsync($"https://graph.facebook.com/debug_token?input_token={accessToken}&access_token={appAccessToken.AccessToken}");
            var userAccessTokenValidation = JsonConvert.DeserializeObject<FacebookUserAccessTokenValidation>(userAccessTokenValidationResponse);

            if (!userAccessTokenValidation.Data.IsValid)
              return null;

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

            return TokenToReturn = _jwtFactory.GenerateEncodedToken(claims);
        }
    }
}