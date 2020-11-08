
using DALContracts;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORDAL
{
    public class OracleConnectionAdapter : IDBConnection
    {
        public OracleConnection Connection { get; }
        public OracleConnectionAdapter(string strConnection)///Todo Complete Contructor
        {
            Connection = new OracleConnection(strConnection);
        }
    }
}
