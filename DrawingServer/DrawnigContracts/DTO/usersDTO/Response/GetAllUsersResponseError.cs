using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.usersDTO.Response
{
    public class GetAllUsersResponseError : ResponseError<string>
    {
        public GetAllUsersResponseError(string msg) : base(msg)
        {

        }
    }
}
