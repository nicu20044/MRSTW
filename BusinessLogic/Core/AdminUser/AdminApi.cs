using BusinessLogic.Services;
using MusicStore.BusinessLogic.Data;
using System.Threading.Tasks;
using Domain.Entities.User;
using BusinessLogic.Interfaces; 

namespace BusinessLogic.Core.AdminUser
{
    public class AdminApi
    {
        private readonly AuthService _authService;
        
        public AdminApi(AuthService authService)
        {
            _authService = authService;
        }

        public async Task<ULoginResponse> LoginActionAsync(ULoginData data)
        {
            return await _authService.UserLoginActionAsync(data);
        }
    }
} 