
using DALContracts;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace ORDAL
{
    public class DALinfra : IDALinfra
    {
        public IDBConnection Connect(string strConnection)
        {
            return new OracleConnectionAdapter(strConnection); 
        }
        private DataSet getDataSet(OracleCommand command)
        {
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(ds);
            return ds;
        }
        public DataSet ExecuteSPQuery(IDBConnection connection, string spName, params IDBParameter[] parameters)
        {
            var command = new OracleCommand();
            command.CommandText = spName;
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = (connection as OracleConnectionAdapter).Connection;

            foreach (var parameter in parameters)
                command.Parameters.Add((parameter as OracleParameterAdapter).Parameter);

            command.Parameters.Add("RC_OUT", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            return getDataSet(command);
        }
        public DataSet ExecuteQuery(IDBConnection connection, string query)
        {
            var command = new OracleCommand();
            command.CommandText = query;
            command.Connection = (connection as OracleConnectionAdapter).Connection;
            return getDataSet(command);

        }
        public IDBParameter getParameter(string paramName, object paramType, object paramValue)
        {
            var retval = new OracleParameterAdapter();
            retval.ParameterName = paramName;
            retval.ParameterType = paramType;
            retval.Value = paramValue;
            return retval;
        }
    }
}
