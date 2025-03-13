using MusicStore.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.BusinessLogic.Interfaces
{
    public interface ISession
    {
        LoginResponse UserLogin(UserLoginData LData);
    }
}
