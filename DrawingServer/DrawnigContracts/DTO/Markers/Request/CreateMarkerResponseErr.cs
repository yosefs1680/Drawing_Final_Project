using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.Markers.Request
{
    public class CreateMarkerResponseErr : ResponseError<string>
    {
        public CreateMarkerResponseErr(string mag): base(mag)
        {

        }
    }
}
