using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.Interface.Sharing;
using Microsoft.AspNetCore.Mvc;

namespace DrawingApp.Controllers.Sharing
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetMySharedDocsCtrl : ControllerBase
    {
        IGetMySharedDocsService _service;
        public GetMySharedDocsCtrl(IGetMySharedDocsService service)
        {
            _service = service;
        }
        [HttpPost]
        public Response GetMySharedDocs([FromBody] Login request)
        {
            return _service.GetMySharedDocs(request);
        }
    }
}
