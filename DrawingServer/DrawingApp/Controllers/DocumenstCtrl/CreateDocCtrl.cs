using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.DTO;
using DrawnigContracts.DTO.documentsDTO.Request;
using DrawnigContracts.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrawingApp.Controllers.docsControllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class CreateDocCtrl : ControllerBase
    {
        ICreateDocService _service;
        public CreateDocCtrl(ICreateDocService service)
        {
            _service = service;
        }
        [HttpPost]
        public Response CreateDoc([FromBody] CreateDocsRequest request)
        {
            return _service.createDoc(request);
        }
    }
}
