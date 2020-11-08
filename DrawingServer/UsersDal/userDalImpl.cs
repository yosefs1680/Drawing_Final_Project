using Contracts;
using DALContracts;
using DrawnigContracts.DTO;
using DrawnigContracts.Interface;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace UsersDal
{
    [Register(Policy.Transient, typeof(IUsersDal))]
    public class userDalImpl : IUsersDal
    {
        IDALinfra _dalInfra;
        IDBConnection _conn;
        string _strConnection;
        public userDalImpl(IDALinfra dalInfra, IConfiguration configuration)
        {
            _dalInfra = dalInfra;
            _strConnection = configuration.GetConnectionString("appDbConnection");
            _conn = _dalInfra.Connect(_strConnection);

        }
        public DataSet GetUser(string userId)
        {
            return _dalInfra.ExecuteSPQuery(_conn, "GET_USER", getIdParam(userId));
        }

        public DataSet CreateUser(RegisterRequest request)
        {
            IDBParameter p_userId = getIdParam(request.Login.UserIdEmail);
            IDBParameter p_userName = _dalInfra.getParameter("USERNAME", OracleDbType.Varchar2, request.UserName);         
            return _dalInfra.ExecuteSPQuery(_conn, "CREATE_USER", p_userId, p_userName);
        }

        public DataSet RemoveUser(string userId)
        {
            return _dalInfra.ExecuteSPQuery(_conn, "REMOVE_USER", getIdParam(userId));
        }

        public DataSet Login(string userId)
        {
            return _dalInfra.ExecuteSPQuery(_conn, "LOGIN", getIdParam(userId));
        }

        public DataSet Logout(string userId)
        {
            return _dalInfra.ExecuteSPQuery(_conn, "LOGOUT", getIdParam(userId));
        }

        public DataSet GetAllUsers()
        {
            return _dalInfra.ExecuteSPQuery(_conn, "GET_ALL_USERS");
        }

        //convert regular params to DBparams
        private IDBParameter getIdParam(string userId)
        {
            return _dalInfra.getParameter("P_USERID", OracleDbType.Varchar2, userId);
        }
    }
}
