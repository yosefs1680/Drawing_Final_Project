using Contracts.DTO;
using DrawnigContracts.DTO.Markers.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.Interface.Markers
{
    public interface IRemoveAllMarkersService
    {
        public Response RemoveAllMarkers(AllMarkersByDocIdRequest DocId);
    }
}
