using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.Entities.User
{
    public class UserLoginData
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
