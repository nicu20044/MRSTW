using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using BusinessLogic.Interfaces;

namespace BusinessLogic.Services
{
    public class SessionBL : ISession
    {
        private readonly Dictionary<int, string> _sessionTokens = new Dictionary<int, string>();

        public string GenerateSessionToken(int userId)
        {
            string token = GenerateSecureToken();
            _sessionTokens[userId] = token;
            return token;
        }

        public bool ValidateSessionToken(int userId, string token)
        {
            return _sessionTokens.ContainsKey(userId) && _sessionTokens[userId] == token;
        }

        public void InvalidateSession(int userId)
        {
            if (_sessionTokens.ContainsKey(userId))
            {
                _sessionTokens.Remove(userId);
            }
        }

        private string GenerateSecureToken()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[32];
                rng.GetBytes(randomBytes);
                return Convert.ToBase64String(randomBytes);
            }
        }
    }
}


