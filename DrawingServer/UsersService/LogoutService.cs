using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.usersDTO.Response;
using DrawnigContracts.Interface;
using DrawnigContracts.Interface.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace UsersService
{
    [Register(Policy.Transient, typeof(ILogoutService))]
    public class LogoutService : ILogoutService
    {
        IUsersDal _dal;
        public LogoutService(IUsersDal dal)
        {
            _dal = dal;
        }
        public Response logout(string userId)
        {
            Response retval = new LogoutResponseError("Can't logout now!");
            try
            {
                var userRow = _dal.Logout(userId).Tables[0].Rows;
                if (userRow[0].Field<Decimal>("ISLOGIN") == 0)
                {
                    retval = new LogoutResponseOk("You are Logout!");
                }
            }
            catch (Exception ex)
            {
                retval = new AppResponseError(ex.Message);
            }
            return retval;
        }
    }
}

