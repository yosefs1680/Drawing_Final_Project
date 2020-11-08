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
    public class IsUserExistCtrl : ControllerBase
    {
        IisUserExistService _service;
        public IsUserExistCtrl(IisUserExistService service)
        {
            _service = service;
        }
        [HttpPost]
        public Response IsUserExist([FromBody]  string userId)
        {
            return _service.isUserExist(userId);
        }
    }
}
