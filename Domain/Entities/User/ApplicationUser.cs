using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.User
{
    public class ApplicationUser : IdentityUser 
    {
        //IdentityUser este o clasă din Microsoft.AspNet.Identity.EntityFramework care are deja campirle de Email,password...
        public string UserRole { get; set; }
        public DateTime LastLoginTime { get; set; }
    }
}