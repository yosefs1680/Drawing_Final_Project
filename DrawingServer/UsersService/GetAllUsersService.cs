using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.usersDTO.Request;
using DrawnigContracts.DTO.usersDTO.Response;
using DrawnigContracts.Interface;
using DrawnigContracts.Interface.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace UsersService
{
    [Register(Policy.Transient, typeof(IGetAllUsersService))]
    public class GetAllUsersService : IGetAllUsersService
    {
        IUsersDal _dal;
        public GetAllUsersService(IUsersDal dal)
        {
            _dal = dal;
        }
        public Response GetAllUsers()
        {
            Response retval;
            try
            {
                var DsUsers = _dal.GetAllUsers();
                if (DsUsers.Tables[0].Rows.Count > 0)
                {
                    var listResult = convertDataToUsersList(DsUsers);
                    retval = new GetAllUsersResponseOk(listResult);
                }
                else
                {
                    retval = new GetAllUsersResponseError("There are no users to present");
                }
            }
            catch
            {
                retval = new AppResponseError("Error, can't fetch users");
            }
            return retval;
        }

        private List<User> convertDataToUsersList(DataSet ds)
        {
            List<User> retval = new List<User>();
            var docsRows = ds.Tables[0].Rows;
            for (int i = 0; i < docsRows.Count; i++)
            {
                try
                {
                    var user = new User(docsRows[i].Field<string>("USERNAME"),
                                        new Login(docsRows[i].Field<string>("USERID")));
                   
                    retval.Add(user);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retval;
        }
    }
}
