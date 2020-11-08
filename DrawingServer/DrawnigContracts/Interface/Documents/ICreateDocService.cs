using Contracts.DTO;
using DrawnigContracts.DTO.documentsDTO.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.Interface
{
    public interface ICreateDocService
    {
        public Response createDoc(CreateDocsRequest request);
    }
}
