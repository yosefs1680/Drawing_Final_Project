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
    public class CreateMarkerCtrl : ControllerBase
    {
        ICreateMarkerService _service;
        public CreateMarkerCtrl(ICreateMarkerService service)
        {
            _service = service;
        }
        [HttpPost]
        public Response CreateMarker([FromBody] CreateMarkerRequest request)
        {
            return _service.CreateMarker(request);
        }
    }
}
