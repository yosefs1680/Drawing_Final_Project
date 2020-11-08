using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.Markers.Request
{
    public class RemoveAllMarkersResponseOk : ResponseOk<string>
    {
        public RemoveAllMarkersResponseOk(string msg) :base(msg)
        {

        }
    }
}
