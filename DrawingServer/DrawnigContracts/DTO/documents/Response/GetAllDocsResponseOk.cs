using DrawnigContracts.DTO.documents;
using DrawnigContracts.DTO.documentsDTO.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.DTO.documentsDTO.Response
{
    public class GetAllDocsResponseOk : ResponseOk<List<Document>>
    {
        public GetAllDocsResponseOk(List<Document> DocsOfUser) : base(DocsOfUser)
        {

        }
    }
}
