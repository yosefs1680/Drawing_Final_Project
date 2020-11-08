using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.documentsDTO.Response
{
   public class GetDocResponseError : ResponseError<string>
    {
        public GetDocResponseError(string msg) : base(msg)
        {

        }
    }
}
