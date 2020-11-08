using Contracts;
using DALContracts;
using DrawnigContracts.DTO.Markers.Request;
using DrawnigContracts.Interface.Markers;
using DrawnigContracts.Interface.Sharing;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace MarkersDal
{
    [Register(Policy.Transient, typeof(IMarkersDal))]
    public class MarkersDalImpl : IMarkersDal
    {
        IDALinfra _dalInfra;
        IDBConnection _conn;
        string _strConnection;
        public MarkersDalImpl(IDALinfra dalInfra, IConfiguration configuration)
        {
            _dalInfra = dalInfra;
            _strConnection = configuration.GetConnectionString("appDbConnection");
            _conn = _dalInfra.Connect(_strConnection);

        }

        public DataSet CreateMarker(CreateMarkerRequest request)
        {
            IDBParameter P_OWNER = _dalInfra.getParameter("P_OWNER", OracleDbType.Varchar2, request.MarkerData.Owner);
            IDBParameter P_DOCID = _dalInfra.getParameter("P_DOCID", OracleDbType.Varchar2, request.MarkerData.DocId);
            IDBParameter P_MARKERID = _dalInfra.getParameter("P_MARKERID", OracleDbType.Varchar2, request.MarkerData.MarkerId);
            IDBParameter P_MARKERTYPE = _dalInfra.getParameter("P_MARKERTYPE", OracleDbType.Varchar2, request.MarkerData.MarkerType);
            IDBParameter P_MARKERLOC = _dalInfra.getParameter("P_MARKERLOC", OracleDbType.Varchar2, JsonConvert.SerializeObject(request.MarkerData.MarkerLoc));
            IDBParameter P_FORECOL = _dalInfra.getParameter("P_FORECOL", OracleDbType.Varchar2, request.MarkerData.ForeColor);
            IDBParameter P_BACKCOL = _dalInfra.getParameter("P_BACKCOL", OracleDbType.Varchar2, request.MarkerData.BackColor);
            return _dalInfra.ExecuteSPQuery(_conn, "CREATE_MARKER", P_OWNER, P_DOCID, P_MARKERID, P_MARKERTYPE,
                                                                    P_MARKERLOC, P_FORECOL, P_BACKCOL);
        }
        public DataSet GetAllMarkers(AllMarkersByDocIdRequest request)
        {
            IDBParameter P_DOCID = _dalInfra.getParameter("P_DOCID", OracleDbType.Varchar2, request.DocId);
            return _dalInfra.ExecuteSPQuery(_conn, "GET_ALL_MARKERS", P_DOCID);
        }

        public DataSet RemoveMarker(MarkerKeysRequest request)
        {
            IDBParameter P_DOCID = _dalInfra.getParameter("P_DOCID", OracleDbType.Varchar2, request.DocId);
            IDBParameter P_MARKERID = _dalInfra.getParameter("P_MARKERID", OracleDbType.Varchar2, request.MarkerId);
            return _dalInfra.ExecuteSPQuery(_conn, "REMOVE_MARKER", P_DOCID, P_MARKERID);
        }
        public DataSet RemoveAllMarkers(string docId)
        {
            IDBParameter P_DOCID = _dalInfra.getParameter("P_DOCID", OracleDbType.Varchar2, docId);
            return _dalInfra.ExecuteSPQuery(_conn, "REMOVE_ALL_MARKERS", P_DOCID);
        }

    }
    
}
