using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.DTO;
using DrawnigContracts.DTO;
using DrawnigContracts.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrawingApp.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class LoginCtrl : ControllerBase
    {
        ILoginService _service;
        public LoginCtrl(ILoginService service)
        {
            _service = service;
        }

        [HttpPost]
        public Response Login([FromBody] LoginRequest request)
        {
            return _service.Login(request);
        }
    }

}