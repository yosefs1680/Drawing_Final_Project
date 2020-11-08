using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts.DTO;
using DrawnigContracts.Interface.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrawingApp.Controllers.userControllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class LogoutCtrl : ControllerBase
    {
        ILogoutService _service;
        public LogoutCtrl(ILogoutService service)
        {
            _service = service;
        }
        [HttpPost]
        public Response Logout([FromBody]  string userId)
        {
            return _service.logout(userId);
        }
    }
}
