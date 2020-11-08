using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.usersDTO.Response
{
    public class LogoutResponseError : ResponseError<string>
    {
        public LogoutResponseError(string msg): base(msg)
        {

        }
    }
}
