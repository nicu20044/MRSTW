using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace MusicStore.BusinessLogic.Data.Repositories
{
        public class UserRepository : IUserRepository
        {
            private readonly AppDbContext _context;

            public UserRepository(AppDbContext context)
            {
                _context = context;
            }

            public async Task DeleteUserAsync(string dataEmail)
            {
                var user = await _context.Users.FindAsync(dataEmail);
                if (user != null)
                {
                    _context.Users.Remove(user);
                    await _context.SaveChangesAsync();
                }
            }

            public async Task AddUserAsync(string email, string hashPassword)
            {
                DateTime newLoginTime = DateTime.UtcNow;
                var user = new ApplicationUser
                {
                    Email = email,
                    PasswordHash = hashPassword,
                    LastLoginTime = newLoginTime
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }

            public async Task<IEnumerable<ApplicationUser>> GetAllUsersAsync()
            {
                return await _context.Users.ToListAsync();
            }

            public async Task<ApplicationUser> GetUserByEmailAsync(string dataEmail)
            {
                return await _context.Users.FirstOrDefaultAsync(u => u.Email == dataEmail);
            }
            
            public async Task<string> GetUserRoleAsync(string dataEmail)
            {
                var user = await _context.Users
                    .Where(u => u.Email == dataEmail)
                    .Select(u => u.UserRole)
                    .FirstOrDefaultAsync();

                return user ?? "Guest";
            }

            public async Task UpdateUserAsync(string email)
            {
                DateTime newLoginTime = DateTime.UtcNow;
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

                if (user != null)
                {
                    user.LastLoginTime = newLoginTime;
                    _context.Users.Update(user);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }

