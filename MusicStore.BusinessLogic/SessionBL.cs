using MusicStore.BusinessLogic.Core;
using MusicStore.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.BusinessLogic
{
    class SessionBL : UserApi, ISession
    {
        public LoginResponse UserLogin(LoginData data)
        {
            return UserLoginAction(data);
        }
    }
}
