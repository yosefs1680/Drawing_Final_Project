using DrawnigContracts.DTO.usersDTO.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.usersDTO.Response
{
    public class GetAllUsersResponseOk : ResponseOk<List<User>>
    {
        public GetAllUsersResponseOk(List<User> users) : base(users) 
        {

        }
    }
}
