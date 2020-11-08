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
    public class RemoveAllMarkersCtrl : ControllerBase
    {
        IRemoveAllMarkersService _service;
        public RemoveAllMarkersCtrl(IRemoveAllMarkersService service)
        {
            _service = service;
        }

        [HttpPost]
        public Response RemoveAllMarkers([FromBody] AllMarkersByDocIdRequest request)
        {
            return _service.RemoveAllMarkers(request);
        }
    }
}

