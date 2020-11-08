using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.Markers.Request
{
    public class RemoveAllMarkersResponseErr : ResponseError<string>
    {
        public RemoveAllMarkersResponseErr(string msg): base(msg)
        {

        }
    }
}
