using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.Markers.Request
{
    public class GetAllMarkersResponseOk : ResponseOk<List<MarkerData>>
    {
        public GetAllMarkersResponseOk(List<MarkerData> list) : base(list)
        {
        }
        
    }
}
