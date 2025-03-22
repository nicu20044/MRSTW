using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities.User;

namespace MusicStore.BusinessLogic.Data
{
    public interface IUserRepository
    {
        Task DeleteUserAsync(string email);
        Task AddUserAsync(string email, string hashPassword);
        Task<IEnumerable<ApplicationUser>> GetAllUsersAsync();
        Task<ApplicationUser> GetUserByEmailAsync(string email);
        Task UpdateUserAsync(string email);
        Task<string> GetUserRoleAsync(string dataEmail);
    }
}