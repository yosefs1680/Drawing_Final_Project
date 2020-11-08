using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.DTO;
using DrawnigContracts.DTO.Sharing.Request;
using DrawnigContracts.Interface.Sharing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrawingApp.Controllers.Sharing
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemoveShareCtrl : ControllerBase
    {
        IRemoveShareService _service;
        public RemoveShareCtrl(IRemoveShareService service)
        {
            _service = service;
        }
        [HttpPost]
        public Response RemoveShare([FromBody] ShareRequest request)
        {
            return _service.removeShare(request);
        }
    }
}
