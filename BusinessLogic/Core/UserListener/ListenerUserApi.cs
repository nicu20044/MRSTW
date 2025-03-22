using BusinessLogic.Services;
using MusicStore.BusinessLogic.Data;
using System.Threading.Tasks;
using Domain.Entities.User;
using BusinessLogic.Interfaces; 

namespace BusinessLogic.Core.AdminUser
{
    public class ListenerUserApi
    {
        private readonly AuthService _authService;
        
        public ListenerUserApi(AuthService authService)
        {
            _authService = authService;
        }

        public async Task<ULoginResponse> LoginActionAsync(ULoginData data)
        {
            return await _authService.UserLoginActionAsync(data);
        }
    }
}