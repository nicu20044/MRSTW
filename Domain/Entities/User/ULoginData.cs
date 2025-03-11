using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.User
{
        public class ULoginData
        {
            public string ID { get; set; }
            public string HashPassword { get; set; }
            public string Email { get; set; }
            public DateTime LoginDateTime { get; set; }
        }

    }

