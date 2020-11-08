using Contracts.DTO;
using DrawnigContracts.DTO.documentsDTO.Request;
using DrawnigContracts.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DrawingApp.Controllers.docsControllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class GetDocCtrl : ControllerBase
    {
        IGetDocService _service;
        public GetDocCtrl(IGetDocService service)
        {
            _service = service;
        }
        [HttpPost]
        public Response GetDoc([FromBody] GetDocRequest request)
        {
            return _service.getDoc(request.DocId);
        }
    }
}

