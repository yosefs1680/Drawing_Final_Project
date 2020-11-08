using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO
{
    public class Login
    {
        public Login(string userIdEmail)
        {
            UserIdEmail = userIdEmail;
        }
        public string UserIdEmail { get; set; }
        //public string userPassword { get; set; }

    }
}
