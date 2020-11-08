using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.usersDTO.Response;
using DrawnigContracts.Interface;
using System;

namespace UsersService
{
    [Register(Policy.Transient, typeof(IRemoveUserService))]
    class RemoveUserService : IRemoveUserService
    {
        IUsersDal _dal;
        public RemoveUserService(IUsersDal dal)
        {
            _dal = dal;
        }
        public Response RemoveUser(string userId)
        {
            Response retval = new RemoveUserResponseError("Removing faild"); ;
            try
            {
                var data = _dal.RemoveUser(userId); // mark as remove, return refCursor
                if (data != null)
                {
                    retval = new RemoveUserResponseOk("Removed successfuly");
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
