using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.DTO;
using DrawnigContracts.DTO.Markers.Request;
using DrawnigContracts.Interface.Markers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrawingApp.Controllers.MarkersCtrl
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemoveMarkerCtrl : ControllerBase
    {
        IRemoveMarkerService _service;
        public RemoveMarkerCtrl(IRemoveMarkerService service)       
        {
            _service = service;
        }
        [HttpPost]
        public Response GetMarker([FromBody] MarkerKeysRequest request)
        {
            return _service.RemoveMarker(request);
        }
    }
}
