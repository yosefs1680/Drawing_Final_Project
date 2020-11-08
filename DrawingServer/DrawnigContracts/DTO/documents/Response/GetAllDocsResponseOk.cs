using DrawnigContracts.DTO.documentsDTO.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.documentsDTO.Response
{
    public class GetAllDocsResponseOk : ResponseOk<List<CreateDocsRequest>>
    {
        public GetAllDocsResponseOk(List<CreateDocsRequest> DocsOfUser) : base(DocsOfUser)
        {

        }
    }
}
