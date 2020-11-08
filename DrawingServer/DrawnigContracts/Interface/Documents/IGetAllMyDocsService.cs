using Contracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.Interface.Documents
{
    public interface IGetAllMyDocsService
    {
        public Response GetAllMyDocs(string userId);
    }
}
