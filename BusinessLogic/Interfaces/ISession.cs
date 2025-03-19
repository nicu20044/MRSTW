using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ISession
    {
        string GenerateSessionToken(int userId);
        bool ValidateSessionToken(string token);
        void InvalidateSession(int userId);
        string GenerateSecureToken();
    }
}
