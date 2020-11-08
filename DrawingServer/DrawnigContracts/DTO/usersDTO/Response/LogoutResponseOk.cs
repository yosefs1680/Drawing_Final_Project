using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.usersDTO.Response
{
    public class LogoutResponseOk : ResponseOk<string>
    {
        public LogoutResponseOk(string msg): base(msg)
        {
        }
    }
}
