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
    public class GetAllMarkersCtrl : ControllerBase
    {
        IGetAllMarkersService _service;
        public GetAllMarkersCtrl(IGetAllMarkersService service)
        {
            _service = service;
        }
        [HttpPost]
        public Response GetAllMarkers([FromBody] AllMarkersByDocIdRequest request)
        {
            return _service.GetAllMarkers(request);
        }
    }
}
