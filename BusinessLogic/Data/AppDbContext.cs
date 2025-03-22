using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace MusicStore.BusinessLogic.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<ApplicationUser> Users { get; set; }
        
    }
}