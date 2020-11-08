using Contracts.DTO;
using DrawnigContracts.DTO.Markers.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.Interface.Markers
{
    public interface IGetAllMarkersService
    {
        public Response GetAllMarkers(AllMarkersByDocIdRequest request);
    }
}
