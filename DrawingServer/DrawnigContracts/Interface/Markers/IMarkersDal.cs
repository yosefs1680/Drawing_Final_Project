using DrawnigContracts.DTO.Markers.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DrawnigContracts.Interface.Markers
{
    public interface IMarkersDal
    {
        public DataSet CreateMarker(CreateMarkerRequest request);
        public DataSet GetAllMarkers(AllMarkersByDocIdRequest request);
        public DataSet RemoveMarker(MarkerKeysRequest request);
        public DataSet RemoveAllMarkers(string docId);

    }
}
