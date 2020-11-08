using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.documentsDTO.Response
{
    public class RemoveDocResponseError : ResponseError<string>
    {
        public RemoveDocResponseError(string msg) : base(msg) { }
    }
}
