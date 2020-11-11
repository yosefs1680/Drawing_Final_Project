using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.documentsDTO.Response
{
    public class CreateDocResponseErr : ResponseError<string>
    {
        public CreateDocResponseErr(string msg) : base(msg) { }

    }
}
