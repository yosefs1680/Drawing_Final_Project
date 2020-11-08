using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.usersDTO.Response
{
    public class RemoveUserResponseOk: ResponseOk<string>
    {
        public RemoveUserResponseOk(string msg) : base(msg)
        {

        }
    }
}
