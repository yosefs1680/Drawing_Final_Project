using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.documentsDTO.Response
{
    public class CreateDocResponseDocExist : ResponseError<string>
    {
        public CreateDocResponseDocExist(string msg) : base(msg) { }

    }
}
