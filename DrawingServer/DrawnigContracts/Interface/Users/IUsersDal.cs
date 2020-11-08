using DALContracts;
using DrawnigContracts.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DrawnigContracts.Interface
{
    public interface IUsersDal
    {
        public DataSet GetUser(string userId);
        public DataSet CreateUser(RegisterRequest request);
        public DataSet RemoveUser(string userId);
        public DataSet Login(string userId);
        public DataSet Logout(string userId);
        public DataSet GetAllUsers();
    }
}
