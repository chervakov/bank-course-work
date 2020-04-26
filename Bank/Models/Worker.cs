using Microsoft.AspNetCore.Identity;

namespace Bank.Models
{
    public class Worker : IdentityUser
    {
        public string Name {get; set;}
        public string Surname {get; set;}
        override public string Email {get; set;}
        override public string UserName{get; set;}
        override public string PasswordHash {get; set;}
        public string Role {get; set;}
        public bool Blocked{get; set;}
    }
}