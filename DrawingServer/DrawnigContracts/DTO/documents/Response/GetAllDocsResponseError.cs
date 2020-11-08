using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.documentsDTO.Response
{
    public class GetAllDocsResponseError : ResponseError<string>
    {
        public GetAllDocsResponseError(string msg) : base(msg)
        {

        }
    }
}
