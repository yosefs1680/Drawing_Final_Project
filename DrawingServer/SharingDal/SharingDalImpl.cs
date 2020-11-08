using Contracts;
using DALContracts;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.Sharing.Request;
using DrawnigContracts.Interface.Sharing;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace SharingDal
{
    [Register(Policy.Transient, typeof(ISharingDal))]
    public class SharingDalImpl : ISharingDal
    {
        IDALinfra _dalInfra;
        IDBConnection _conn;
        string _strConnection;
        public SharingDalImpl(IDALinfra dalInfra, IConfiguration configuration)
        {
            _dalInfra = dalInfra;
            _strConnection = configuration.GetConnectionString("appDbConnection");
            _conn = _dalInfra.Connect(_strConnection);

        }
        public DataSet CreateShare(ShareRequest request)
        {
            IDBParameter p_user = _dalInfra.getParameter("UserId", OracleDbType.Varchar2, request.UserId);
            IDBParameter p_docId = _dalInfra.getParameter("DocId", OracleDbType.Varchar2, request.DocId);
           
            return _dalInfra.ExecuteSPQuery(_conn, "CREATE_SHARE", p_docId, p_user);
        }
        public DataSet GetMySharedDocs(Login request)
        {
            IDBParameter p_User = _dalInfra.getParameter("User", OracleDbType.Varchar2, request.UserIdEmail);

            return _dalInfra.ExecuteSPQuery(_conn, "GET_MY_SHARED_DOCS", p_User);
        }
        // remove sharing with specific users
        public DataSet RemoveShare(ShareRequest request)
        {
            IDBParameter p_docId = _dalInfra.getParameter("DocId", OracleDbType.Varchar2, request.DocId);
            IDBParameter p_userId = _dalInfra.getParameter("UserId", OracleDbType.Varchar2, request.UserId);
            return _dalInfra.ExecuteSPQuery(_conn, "REMOVE_SHARE", p_docId, p_userId);
        }
    }
}

