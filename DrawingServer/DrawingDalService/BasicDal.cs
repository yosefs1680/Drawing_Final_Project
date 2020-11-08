
using Contracts;
using DALContracts;
using DrawnigContracts.Interface.DAL;
using System;
using System.Data;

//Responsible for creating a connection to DB, and sending SP
namespace BasicDalLib
{
    [Register(Policy.Transient, typeof(IBasicDal))]
    public class BasicDal : IBasicDal
    {
        protected IDBConnection _connection;
        protected string _strConnection =
            "DATA SOURCE = localhost:1521/XE; PASSWORD = 1234; USER ID = C##SIMHONY";
        protected IDALinfra _dalInfra;

        public BasicDal(IDALinfra dalInfra)
        {
            _dalInfra = dalInfra;
            Connect();
        }
        public IDBConnection Connection { get => _connection; }
        public string StrConnection { set => _strConnection = value; }
        public IDALinfra DalInfra { get => _dalInfra; set => _dalInfra = value; }

        public void Connect()
        {
            _connection = _dalInfra.Connect(_strConnection);
        }

        public DataSet sendSPToExe(string spName, params IDBParameter[] parametrs)
        {
            return DalInfra.ExecuteSPQuery(Connection, spName, parametrs);
        }
    }
}
