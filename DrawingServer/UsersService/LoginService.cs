using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.Interface;
using System;
using System.Data;

namespace UsersService
{
    [Register(Policy.Transient,typeof(ILoginService))]
    public class LoginService : ILoginService
    {
        IUsersDal _dal;
        public LoginService(IUsersDal dal)
        {
            _dal = dal;
        }
        public Response Login(LoginRequest request)
        {
            Response retval = new LoginResponseMailNotExist("You haven't account yet, please register first");
            try
            {
                var signInRow = _dal.Login(request.Login.UserIdEmail).Tables[0].Rows;
                if (signInRow[0].Field<Decimal>("ISLOGIN") == 1 &&
                     (signInRow[0].Field<Decimal>("ISACTIVE") == 1) )
                {
                    retval = new LoginResponseOk("You are Login!");            
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
