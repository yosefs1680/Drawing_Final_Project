using Contracts.DTO;
using DrawnigContracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.Interface
{
    public interface IUsersService
    {
        public Response Register(RegisterRequest request);
    }
}
