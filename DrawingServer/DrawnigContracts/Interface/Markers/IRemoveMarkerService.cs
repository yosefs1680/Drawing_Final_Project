using Contracts.DTO;
using DrawnigContracts.DTO.Markers.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.Interface.Markers
{
    public interface IRemoveMarkerService
    {
        public Response RemoveMarker(MarkerKeysRequest request);
    }
}
