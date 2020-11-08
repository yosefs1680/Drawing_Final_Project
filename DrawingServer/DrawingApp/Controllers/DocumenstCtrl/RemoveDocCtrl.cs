using Contracts.DTO;
using DrawnigContracts.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DrawingApp.Controllers.docsControllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class RemoveDocCtrl : ControllerBase
    {
        IRemoveDocService _service;
        public RemoveDocCtrl(IRemoveDocService service)
        {
            _service = service;
        }
        [HttpPost]
        public Response RemoveDoc([FromBody]  string docId)
        {
            return _service.removeDoc(docId);
        }
    }
}
