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
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllUsersCtrl : ControllerBase
    {
        IGetAllUsersService _service;
        public GetAllUsersCtrl(IGetAllUsersService service)
        {
            _service = service;
        }
        [HttpPost]
        public Response GetAllUsers()
        {
            return _service.GetAllUsers();
        }
    }
}
