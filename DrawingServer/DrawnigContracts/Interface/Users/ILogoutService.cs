using Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.Interface.Users
{
    public interface ILogoutService
    {
        public Response logout(string userId);
    }
}
