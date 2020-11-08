using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.usersDTO.Response
{
    public class RemoveUserResponseError : ResponseOk<string>
    {
        public RemoveUserResponseError(string msg) : base(msg)
        {

        }
    }
}
