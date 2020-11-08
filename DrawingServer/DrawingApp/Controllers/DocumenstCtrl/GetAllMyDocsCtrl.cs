using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.DTO;
using DrawnigContracts.DTO.documentsDTO.Request;
using DrawnigContracts.Interface.Documents;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrawingApp.Controllers.docsControllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class GetAllMyDocsCtrl : ControllerBase
    {
        IGetAllMyDocsService _service;
        public GetAllMyDocsCtrl(IGetAllMyDocsService service)
        {
            _service = service;
        }
        [HttpPost]
        public Response GetAllMyDocs([FromBody] GetAllDocsRequest request)
        {
            return _service.GetAllMyDocs(request.UserId);
        }
    }
}
