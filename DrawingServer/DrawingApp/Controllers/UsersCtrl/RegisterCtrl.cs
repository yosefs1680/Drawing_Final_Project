using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DrawingApp.Controllers.userControllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class RegisterCtrl : ControllerBase
    {
        IRegisterService _service;
        public RegisterCtrl(IRegisterService service)
        {
            _service = service;
        }

        //When a parameter has [FromBody], Web API uses the Content-Type header to select a formatter
        [HttpPost]
        public Response Register([FromBody] RegisterRequest request)
        {
            return _service.Register(request);
        }
    }
}