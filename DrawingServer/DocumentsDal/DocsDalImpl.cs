using Contracts;
using DALContracts;
using DrawnigContracts.DTO.documentsDTO.Request;
using DrawnigContracts.Interface;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DocumentsDal
{
    [Register(Policy.Transient, typeof(IDocsDal))]
    public class DocsDalImpl : IDocsDal
    {
        IDALinfra _dalInfra;
        IDBConnection _conn;
        string _strConnection;
        public DocsDalImpl(IDALinfra dalInfra, IConfiguration configuration)
        {
            _dalInfra = dalInfra;
            _strConnection = configuration.GetConnectionString("appDbConnection");
            _conn = _dalInfra.Connect(_strConnection);
            
        }       
        public DataSet CreateDoc(CreateDocsRequest request)
        {
            IDBParameter p_owner = _dalInfra.getParameter("Owner", OracleDbType.Varchar2, request.Owner);
            IDBParameter p_docId = _dalInfra.getParameter("DocId", OracleDbType.Varchar2, request.DocId);
            IDBParameter p_docUrl = _dalInfra.getParameter("DocUrl", OracleDbType.Varchar2, request.DocUrl);
            IDBParameter p_docName = _dalInfra.getParameter("DocName", OracleDbType.Varchar2, request.DocName);
            return _dalInfra.ExecuteSPQuery(_conn, "CREATE_DOC", p_owner, p_docId, p_docUrl, p_docName);
        }
        public DataSet GetDoc(string docId)
        {
            IDBParameter p_docId = _dalInfra.getParameter("DocId", OracleDbType.Varchar2, docId);
            return _dalInfra.ExecuteSPQuery(_conn, "GET_DOC", p_docId);
        }
        public DataSet RemoveDoc(string docId)
        {
            IDBParameter p_docId = _dalInfra.getParameter("DocId", OracleDbType.Varchar2, docId);
            return _dalInfra.ExecuteSPQuery(_conn, "REMOVE_DOC", p_docId);
        }
        public DataSet GetAllDocsOfUser(string userId)
        {
            IDBParameter p_userId = _dalInfra.getParameter("UserId", OracleDbType.Varchar2, userId);
            return _dalInfra.ExecuteSPQuery(_conn, "GET_ALL_DOCS_OF_USER", p_userId);
        }
    }
}

