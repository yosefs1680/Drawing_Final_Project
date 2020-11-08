using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.Markers.Request
{
    public class RemoveMarkerResponseOk : ResponseOk<string>
    {
        public RemoveMarkerResponseOk(string msg): base(msg)
        {

        }
    }
}
