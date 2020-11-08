using Contracts.DTO;
using DrawnigContracts.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DrawingApp.Controllers.userControllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class RemoveUserCtrl : ControllerBase
    {
        IRemoveUserService _service;
        public RemoveUserCtrl(IRemoveUserService service)
        {
            _service = service;
        }
        [HttpPost]
        public Response RemoveUser([FromBody] string userId)
        {
            return _service.RemoveUser(userId);
        }
    }
}
