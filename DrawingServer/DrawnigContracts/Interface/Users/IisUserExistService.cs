using Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.Interface.Users
{
    public interface IisUserExistService
    {
        public Response isUserExist(string userId);
    }
}
