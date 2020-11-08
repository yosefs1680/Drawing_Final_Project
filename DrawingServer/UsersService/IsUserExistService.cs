using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.Interface;
using DrawnigContracts.Interface.Users;
using System;

namespace UsersService
{
    [Register(Policy.Transient, typeof(IisUserExistService))]
    class IsUserExistService : IisUserExistService
    {
        IUsersDal _dal;
        public IsUserExistService(IUsersDal dal)
        {
            _dal = dal;
        }
        public Response isUserExist (string userId)
        {
            Response retval = new IsExistResponseError(false);
            try
            {
                var dataSet = _dal.GetUser(userId);               
                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    retval = new IsExistResponseOk(true); ;
                }                    
            }
            catch (Exception ex)
            {
                new AppResponseError(ex.Message);
            }
            return retval;
        }
    }
}
