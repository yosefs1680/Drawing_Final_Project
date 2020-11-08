using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.Interface;
using System;

namespace UsersService
{
    [Register(Policy.Transient,typeof(IRegisterService))]
    public class RegisterService : IRegisterService
    {
        IUsersDal _dal;
        public RegisterService(IUsersDal dal)
        {
            _dal = dal;
        }
        public Response Register(RegisterRequest request)
        {
            Response retval = new RegisterResponseOk("You registered successfuly");
            try
            {
                // first check if user exist
                var ds = _dal.GetUser(request.Login.UserIdEmail);                
                if (ds.Tables[0].Rows.Count == 0)
                {
                    _dal.CreateUser(request);
                }
                else
                {
                    retval = new RegisterResponseUserExist("User exist");
             
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
