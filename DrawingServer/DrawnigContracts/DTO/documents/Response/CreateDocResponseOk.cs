using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.documentsDTO.Response
{
    public class CreateDocResponseOk : ResponseOk<string>
    {
        public CreateDocResponseOk(string data) : base(data) { }    
    }
}
