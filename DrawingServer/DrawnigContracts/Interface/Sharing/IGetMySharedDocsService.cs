using Contracts.DTO;
using DrawnigContracts.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawnigContracts.Interface.Sharing
{
    public interface IGetMySharedDocsService
    {
        public Response GetMySharedDocs(Login request);
    }
}
