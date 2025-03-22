using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using Domain.Entities.User;
using MusicStore.BusinessLogic.Data;

using BusinessLogic.Interfaces;

namespace BusinessLogic.Services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly ISession _session;

        public AuthService(IUserRepository userRepository, ISession session)
        {
            _userRepository = userRepository;
            _session = session;
        }

        public async Task<ULoginResponse> UserLoginActionAsync(ULoginData data)
        {
            try
            {
                var validate = new EmailAddressAttribute();
                if (!validate.IsValid(data.Email))
                {
                    return new ULoginResponse { Status = false, StatusMsg = "Email invalid." };
                }

                ApplicationUser result = await _userRepository.GetUserByEmailAsync(data.Email);
                if (result == null)
                {
                    return new ULoginResponse { Status = false, StatusMsg = "Username sau parolă incorecte." };
                }

                string hashedPass = LoginHelper.HashGen(data.HashPassword);
                if (result.PasswordHash != hashedPass)
                {
                    return new ULoginResponse { Status = false, StatusMsg = "Username sau parolă incorecte." };
                }
                
                await _userRepository.UpdateUserAsync(result.Email);

                // Determinare rol utilizator
                string userRole = await _userRepository.GetUserRoleAsync(result.Email);


                // Generare token sesiune
                string sessionToken = _session.GenerateSessionToken(int.Parse(result.Id));

                return new ULoginResponse { Status = true, UserRole = userRole, Token = sessionToken };
            }
            catch (Exception ex)
            {
                return new ULoginResponse { Status = false, StatusMsg = "Eroare de server: " + ex.Message };
            }
        }
        public static class LoginHelper
        {
            public static string HashGen(string password)
            {
                using (var sha256 = SHA256.Create())
                {
                    var bytes = Encoding.UTF8.GetBytes(password);
                    var hash = sha256.ComputeHash(bytes);
                    return Convert.ToBase64String(hash);
                }
            }
        }
    }

}





        
