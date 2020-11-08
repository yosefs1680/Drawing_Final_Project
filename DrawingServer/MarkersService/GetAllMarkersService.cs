using Contracts;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.DTO.Markers;
using DrawnigContracts.DTO.Markers.Request;
using DrawnigContracts.Interface.Markers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MarkersService
{
    [Register(Policy.Transient, typeof(IGetAllMarkersService))]
    public class GetAllMarkersService : IGetAllMarkersService
    {
        IMarkersDal _dal;
        public GetAllMarkersService(IMarkersDal dal)
        {
            _dal = dal;
        }
        public Response GetAllMarkers(AllMarkersByDocIdRequest request)
        {
            Response retval;
            try
            {
                var dsAllMarkers = _dal.GetAllMarkers(request);
                if (dsAllMarkers.Tables[0].Rows.Count > 0)
                {
                    var AllMarkers = convertDataSetToClass(dsAllMarkers);
                    retval = new GetAllMarkersResponseOk(AllMarkers);
                }
                else
                {
                    retval = new GetAllMarkersResponseErr("There is no marker with this ID");
                }
            }
            catch (Exception ex)
            {
                retval = new AppResponseError("Can't fetch marker from DB\n" + ex.Message);
            }
            return retval;
        }
        private List<MarkerData> convertDataSetToClass(DataSet data)
        {
            var result = new List<MarkerData>();
            foreach (DataRow row in data.Tables[0].Rows)
            {
                MarkerData marker = new MarkerData();
                try
                {
                    marker.Owner = row.Field<string>("OWNER");
                    marker.DocId = row.Field<string>("DOCID");
                    marker.MarkerId = row.Field<string>("MARKERID");
                    marker.MarkerType = row.Field<string>("MARKERTYPE");
                    // { position: {X:x, Y:y}, radius: {X:x, Y:y} }
                    marker.MarkerLoc = JsonConvert
                        .DeserializeObject<MarkerLocation>(row.Field<string>("MARKERLOC"));                                        
                    marker.ForeColor = row.Field<string>("FORECOLOR");
                    marker.BackColor = row.Field<string>("BACKCOLOR");

                    result.Add(marker);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }
    }
}
