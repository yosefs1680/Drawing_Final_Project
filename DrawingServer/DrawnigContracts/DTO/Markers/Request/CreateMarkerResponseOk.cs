using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DrawnigContracts.DTO.Markers.Request
{
    public class CreateMarkerResponseOk : ResponseOk<string>
    {
        public CreateMarkerResponseOk(string msg): base(msg)
        {
           
        }
    }
}
