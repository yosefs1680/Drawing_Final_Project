using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.Markers.Request
{
    public class RemoveMarkerResponseErr : ResponseError<string>
    {
        public RemoveMarkerResponseErr(string msg): base (msg)
        {

        }
    }
}
