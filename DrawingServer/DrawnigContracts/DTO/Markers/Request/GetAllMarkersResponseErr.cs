using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.Markers.Request
{
    public class GetAllMarkersResponseErr : ResponseError<string>
    {
        public GetAllMarkersResponseErr(string msg): base(msg)
        {

        }
    }
}
