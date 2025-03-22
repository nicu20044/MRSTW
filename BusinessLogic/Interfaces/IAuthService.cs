using System.Threading.Tasks;
using Domain.Entities.User;

namespace BusinessLogic.Interfaces
{
    public interface IAuthService
    {
            Task<ULoginResponse> LoginActionAsync(ULoginData data);
    }
}

