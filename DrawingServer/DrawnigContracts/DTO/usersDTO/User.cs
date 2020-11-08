using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.usersDTO.Request
{
    public class User
    {
        
        public User(string userName, Login login)
        {
            UserName = userName;
            Login = login;
        }
        public string UserName { get; set; }
        public Login Login { get; set; }
    }
}
